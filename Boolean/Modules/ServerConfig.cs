using Discord;
using Discord.Interactions;
using Discord.WebSocket;

namespace Boolean;

public class ServerConfig
{
    // /set, used to set configuration options
    [DefaultMemberPermissions(GuildPermission.Administrator)]
    [Group("set", "Set configuration options")]
    public class ServerSet(DataContext db, Config config)
        : InteractionModuleBase<SocketInteractionContext>
    {
        [SlashCommand("role", "Configure roles for this server")]
        public async Task Role()
        {
            
        } 
    }
    // /get, used to get configuration options
    [DefaultMemberPermissions(GuildPermission.Administrator)]
    [Group("get", "Get configuration options")]
    public class ServerGet(DataContext db, Config config)
        : InteractionModuleBase<SocketInteractionContext>
    {
        [SlashCommand("role", "Configure roles for this server")]
        public async Task Role()
        {
            
        } 
    }
}