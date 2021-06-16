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
    RenderCaller->start(17);
}

MainWindow::~MainWindow()
{
    delete ui;
}


void MainWindow::on_pushButton_clicked()
{
    DiscordHandler::SetStatus();
}

void MainWindow::SimulateFrame()
{
    DiscordHandler::Render();
}


