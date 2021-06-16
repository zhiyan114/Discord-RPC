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
        case discord::Result::InvalidBase64:
            return "Invalid Base64";
        case discord::Result::Ok:
            return "OK";
        default:
            return "Invalid Enum/Unavailable Enum";

    }
}

discord::Result DiscordHandler::init(long long clientid) {
    return discord::Core::Create(clientid, DiscordCreateFlags_Default, &discordMain);

}
void DiscordHandler::SetStatus(discord::Activity Activity, std::function<void(discord::Result)> callback) {
    discordMain->ActivityManager().UpdateActivity(Activity, callback);
}
bool DiscordHandler::isInit() {
    if(discordMain) {
        return true;
    }
    return false;
}
void DiscordHandler::Render() {
    discordMain->RunCallbacks();
}

