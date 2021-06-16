#include "mainwindow.h"
#include <QScopeGuard>
#include <DiscordHandler.h>

#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MainWindow w;
    // Load Sentry Handler
    sentry_options_t *options = sentry_options_new();
    sentry_options_set_dsn(options, "https://e7429b15340e42d288e15ff0026daa8d@o125145.ingest.sentry.io/5818668");
    sentry_options_set_release(options, "Internal-DiscordRPC@1.0.0");
    auto sentryClose = qScopeGuard([] { sentry_close(); });
    // Load Discord RPC Handler
    //DiscordHandler::init(854404100342153236);
    // Load UI Handler
    sentry_init(options);
    w.show();
    return a.exec();
}
