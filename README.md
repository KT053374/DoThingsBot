# About
A tinker/buff/portal bot plugin.
Ripped from https://gitlab.com/trevis/dothingsbot

# Contributors
Schubaal

# Installation:
 - Requires Decal / Virindi View System (comes with virindi bundle)
 - Install [DoThingsBotInstaller-2.0.0.7.exe](https://github.com/KT053374/DoThingsBot/blob/d1e6f03b0c57db3e7bc6dee0865149907cda791e/Installer/DoThingsBotInstaller-2.0.0.7.exe)
    
# How to use:
 - The AC window cannot be minimized while the bot is running.

 - UseCraftSuccessDialog should be set to on.
    -  Run `/config UseCraftSuccessDialog on` in the chat window.
        -   If you get a message in the chat window that states 
            - `The command "config" is not currently enabled on this server.`  
        - The server admin will need to run the following command to turn player_config_command on.
            - `/modifybool player_config_command true`
 - TODO, but hopefully fairly self explanitory.

# Known Issues
 - You must relog the bot after learning spells (from professors at least, untested with scrolls)
 - The bot does not work if the ac window is minimized.  It does not have to be in focus.

# Recipes
- Recipes are stored in <install_dir>/Resources/recipes.xml
- [Supported recipes](https://gitlab.com/trevis/dothingsbot/wikis/recipes)

# Screenshots
![](https://i.gyazo.com/ba7c1b6dedf462864c74d54f4541de73.png)
![](https://i.gyazo.com/2f1cbb53dda27fa07d2ab6b8bf2f53bb.png)

# TODO
 - Calculate success chance on the bot instead of using ingame popup window
 - Tradebot
 - Equipment mana managment
 - Brilliance
