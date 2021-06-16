#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <DiscordHandler.h>
#include <sentry.h>


MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    RenderCaller = new QTimer(this);
    connect(RenderCaller,SIGNAL(timeout()),this,SLOT(SimulateFrame()));
}

MainWindow::~MainWindow()
{
    delete ui;
}


void MainWindow::on_pushButton_clicked()
{
    if(!DiscordHandler::isInit()) {
        Msgbox.setText("Application is not initiated, please initiate it before trying again.");
        Msgbox.setIcon(QMessageBox::Icon::Warning);
        Msgbox.exec();
        return;
    }
    discord::Activity activity{};
    activity.SetState(ui->StatusState->text().toLocal8Bit());
    activity.SetDetails(ui->StatusDetail->text().toLocal8Bit());
    activity.SetName(ui->StatusName->text().toLocal8Bit());
    if(ui->isWatching->isChecked() == true) {
        activity.SetType(discord::ActivityType::Watching);
    } else if(ui->isListening->isChecked()) {
        activity.SetType(discord::ActivityType::Listening);
    } else if(ui->isPlaying->isChecked()) {
        activity.SetType(discord::ActivityType::Playing);
    } else if(ui->isStreaming->isChecked()) {
        activity.SetType(discord::ActivityType::Streaming);
    } else {
        Msgbox.setText("Please select a RPC Status");
        Msgbox.setIcon(QMessageBox::Icon::Critical);
        Msgbox.exec();
    }

    DiscordHandler::Status::SetStatus(activity,[](discord::Result result) {
        QMessageBox MsgboxHandler;
        if(result != discord::Result::Ok) {
            MsgboxHandler.setText("An error occured while trying to save result: "+QString::fromUtf8(DiscordHandler::Translate::ResultToString(result).c_str()));
            MsgboxHandler.setIcon(QMessageBox::Icon::Critical);
            MsgboxHandler.exec();
            return;
        }
        MsgboxHandler.setText("Status Successfully Set.");
        MsgboxHandler.setIcon(QMessageBox::Icon::Information);
        MsgboxHandler.exec();
    });
}

void MainWindow::SimulateFrame()
{
    DiscordHandler::Render();
}


void MainWindow::on_pushButton_2_clicked() // Init for Discord Application
{
    if(DiscordHandler::isInit() == true) {
        Msgbox.setText("Discord Application is already loaded, restart the software to load a different one.");
        Msgbox.setIcon(QMessageBox::Icon::Critical);
        Msgbox.exec();
        return;
    }
    bool ConvertOk;
    long long InitID = ui->AppID->text().toULongLong(&ConvertOk);
    if(ConvertOk == false) {
        Msgbox.setText("Invalid input, maybe it contained more than just a number?");
        Msgbox.setIcon(QMessageBox::Icon::Critical);
        Msgbox.exec();
        return;
    }
    discord::Result initresult = DiscordHandler::init(InitID);
    if(initresult != discord::Result::Ok) {
        Msgbox.setText("An Error Occured while trying to initiate the application ID: "+ QString::fromUtf8(DiscordHandler::Translate::ResultToString(initresult).c_str()));
        Msgbox.setIcon(QMessageBox::Icon::Critical);
        Msgbox.exec();
        return;
    }
    ui->pushButton_2->setDisabled(true);
    ui->AppID->setReadOnly(true);
    RenderCaller->start(17); // Approx. 60fps. Can't use 1/60 as it will spike CPU usage.
    Msgbox.setText("Application was successfully initiated.");
    Msgbox.setIcon(QMessageBox::Icon::Information);
    Msgbox.exec();
}

