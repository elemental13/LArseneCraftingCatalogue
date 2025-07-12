rem Copy file directly to the pi server
scp -r .\bin\Release\net9.0\linux-arm64\publish\* pi@raspberrypi:LarseneCraftingCatalogue
rem Make sure the excutable has the correct x permissions, can be checked with ls -l
ssh pi@raspberrypi "sudo chmod -R +x LarseneCraftingCatalogue && cd LarseneCraftingCatalogue"