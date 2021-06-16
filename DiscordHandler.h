#ifndef DISCORDHANDLER_H
#define DISCORDHANDLER_H
#include <iostream>
#include <string>
#include <discord.h>

namespace DiscordHandler {
namespace Translate {
 std::string ResultToString(discord::Result discresult);
}
void init();
void SetStatus(); // Accepting variable later
void Render();
}

#endif // DISCORDHANDLER_H
