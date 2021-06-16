#include <DiscordHandler.h>
#include <sentry.h>
#include<QDebug>
discord::Core* discordMain;
std::string DiscordHandler::Translate::ResultToString(discord::Result result) {
    switch(result) {
        case discord::Result::ApplicationMismatch:
            return "Application Mismatch";
        case discord::Result::CaptureShortcutAlreadyListening:
            return "Capture Shortcut Already Listening";
        case discord::Result::Conflict:
            return "Conflict";
        case discord::Result::GetGuildTimeout:
            return "Get Guild Timeout";
        case discord::Result::InsufficientBuffer:
            return "Insufficient Buffer";
        case discord::Result::InternalError:
            return "Internal Error";
        case discord::Result::InvalidAccessToken:
            return "Invalid Access Token";
        case discord::Result::Ok:
            return "OK";
        default:
            return "Invalid Enum/Unavailable Enum";

    }
}

void DiscordHandler::init() {
    auto result = discord::Core::Create(854404100342153236, DiscordCreateFlags_Default, &discordMain);
    //discord::Result result = discordMain->Create(854404100342153236,DiscordCreateFlags_Default,&discordMain);
    qInfo(Translate::ResultToString(result).c_str());
    if(result != discord::Result::Ok) {
        qInfo("AN ERROR OCCURED DURING INIT");
        sentry_capture_event(sentry_value_new_message_event(
          /*   level */ SENTRY_LEVEL_FATAL,
          /*  logger */ "RPC Init",
          /* message */ Translate::ResultToString(result).c_str()
        ));
    }

}
void DiscordHandler::SetStatus() {
    discord::Activity activity{};
    activity.SetState("Testing");
    activity.SetDetails("Fruit Loops");
    activity.SetType(discord::ActivityType::Playing);
    discordMain->ActivityManager().UpdateActivity(activity, [](discord::Result result) {
        qInfo("Status Set");
        if(result != discord::Result::Ok) {
            sentry_capture_event(sentry_value_new_message_event(
              /*   level */ SENTRY_LEVEL_FATAL,
              /*  logger */ "RPC Status Modifier",
              /* message */ Translate::ResultToString(result).c_str()
            ));
        }
    });
}
void DiscordHandler::Render() {
    if(discordMain) {
        discordMain->RunCallbacks();
    }
}

