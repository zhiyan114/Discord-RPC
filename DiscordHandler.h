#ifndef DISCORDHANDLER_H
#define DISCORDHANDLER_H
#include <iostream>
#include <string>
#include <discord.h>

namespace DiscordHandler {
    namespace Translate {
        std::string ResultToString(discord::Result discresult);
    }
    discord::Result init(long long clientid);
    void Render();
    bool isInit();
    namespace Status {
        void SetStatus(discord::Activity Activity,std::function<void(discord::Result)> callback); // Accepting variable later
    }
    namespace User {
        void GetID();
        void GetName();
    }
}

#endif // DISCORDHANDLER_H
