using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Classes
{
    public class Conexao
    {

        public static string StringConexao { get; set; }



        public static void EncriptaConexao()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(@"D:\Projetos\ProjetoVillaBeach\ProjetoVillaBeach\bin\Debug\net5.0-windows\ProjetoVillaBeach.exe");
            // Let's work with the <connectionStrings> section
            ConfigurationSection connectionStrings = config.GetSection("connectionStrings");

            if (connectionStrings != null)
            {
                // Only encrypt the section if it is not already protected
                if (!connectionStrings.SectionInformation.IsProtected)
                {
                    // Encrypt the <connectionStrings> section using the 
                    // DataProtectionConfigurationProvider provider
                    connectionStrings.SectionInformation.ProtectSection(
                        "DataProtectionConfigurationProvider");
                    config.Save();
                }
            }
        }

        public static void DecriptaConexao()
        {
            // Get configuration information about App.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Let's work with the <connectionStrings> section
            ConfigurationSection connectionStrings = config.GetSection("connectionStrings");

            if (connectionStrings != null)
            {
                // Only decrypt the section if it is protected
                if (connectionStrings.SectionInformation.IsProtected)
                {
                    // Decrypt the <connectionStrings> section
                    connectionStrings.SectionInformation.UnprotectSection();
                    config.Save();
                }
            }
        }
    }
}
