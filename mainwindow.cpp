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
    RenderCaller->start(17); // Approx. 60fps. Can't use 1/60 as it will spike CPU usage.
}

MainWindow::~MainWindow()
{
    delete ui;
}


void MainWindow::on_pushButton_clicked()
{
    discord::Activity activity{};
    activity.SetState("Testing");
    activity.SetDetails("Something");
    activity.SetType(discord::ActivityType::Playing);
    DiscordHandler::SetStatus(activity);
}

void MainWindow::SimulateFrame()
{
    DiscordHandler::Render();
}


