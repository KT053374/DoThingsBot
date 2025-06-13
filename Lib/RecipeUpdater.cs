using System;
using System.IO;
using System.Net;

namespace DoThingsBot.Lib {
    public static class RecipeUpdater {
        private static string xml = "";

        public static void CheckForUpdate() {
            new Action(FetchRecipeData).BeginInvoke(new AsyncCallback(OnFetchComplete), null);
        }

        private static void FetchRecipeData() {
            try {
                var url = "https://raw.githubusercontent.com/KT053374/DoThingsBot/main/Resources/recipes.xml";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 10000;
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) {
                    using (Stream stream = response.GetResponseStream()) {
                        using (StreamReader reader = new StreamReader(stream)) {
                            xml = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex) {
                Util.LogException(ex);
            }
        }

        private static void OnFetchComplete(IAsyncResult result) {
            try {
                if (!string.IsNullOrEmpty(xml)) {
                    try {
                        var path = Path.Combine(Util.GetResourcesDirectory(), "recipes.xml");
                        File.WriteAllText(path, xml);
                        Recipes.LoadRecipes();
                        Globals.Host.Actions.AddChatText("[" + Globals.PluginName + "] Updated recipes.xml from repository.", 3);
                    }
                    catch (Exception ex) { Util.LogException(ex); }
                }
            }
            catch (Exception ex) {
                Util.LogException(ex);
            }
        }
    }
}
