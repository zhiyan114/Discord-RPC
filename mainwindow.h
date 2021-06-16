#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <discord.h>
#include <sentry.h>
#include <QTimer>
#include <QMessageBox>

QT_BEGIN_NAMESPACE
namespace Ui { class MainWindow; }
QT_END_NAMESPACE
class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();


private slots:
    void on_pushButton_clicked();

    void on_pushButton_2_clicked();

public slots:
    void SimulateFrame();

private:
    Ui::MainWindow *ui;
    QTimer *RenderCaller;
    QMessageBox Msgbox;
};
#endif // MAINWINDOW_H
