#ifndef DISCORDHANDLER_H
#define DISCORDHANDLER_H
#include <iostream>
#include <string>
#include <discord.h>

namespace DiscordHandler {
namespace Translate {
 std::string ResultToString(discord::Result discresult);
}
void init(long long clientid);
void SetStatus(discord::Activity Activity); // Accepting variable later
void Render();
}

#endif // DISCORDHANDLER_H
