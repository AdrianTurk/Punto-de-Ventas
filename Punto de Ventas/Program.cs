namespace Punto_de_Ventas
{
        [Flags]
    public enum UserGrants
        { 
            A_STOCKVIEW     =   1,
            A_STOCKRESERVED =   1<<1 | A_PRODUCTADD,
            A_PRODUCTADD    =   1<<2 | A_PRODUCTCHANGE,
            A_PRODUCTCHANGE =   1<<3 | A_STOCKVIEW,        //Changes Name and minium stock
            A_SALESVIEW     =   1<<4,
            A_SALESADD      =   1<<5,
            A_SALESCHANGE   =   1<<6 | A_SALESVIEW,
            A_CLIENTVIEW    =   1<<7,
            A_CLIENTCHANGE  =   1<<8 | A_CLIENTVIEW,
            A_PURCHASESVIEW =   1<<9,
            A_PURCHASECHANGE=   1<<10 | A_PURCHASESVIEW,
            A_SUPPLIERSVIEW =   1<<11,
            A_SUPPLIERSCHANGE=  1<<12 | A_SUPPLIERSVIEW,
            A_REPORTSVIEW   =   1<<13,
            R_ADMIN         =   0xFFFF,
            R_NONE          =   0x0000,
            R_SELLER        =   A_SALESVIEW | A_SALESADD | A_CLIENTCHANGE | A_STOCKVIEW | A_PURCHASESVIEW | A_REPORTSVIEW,
            R_REPOSITOR     =   A_PRODUCTADD |  A_PURCHASECHANGE | A_SUPPLIERSCHANGE,
            R_ADVANCED      =   R_SELLER | R_REPOSITOR,
            R_AUDITOR       =   A_STOCKVIEW | A_CLIENTVIEW | A_PURCHASESVIEW | A_SUPPLIERSVIEW | A_REPORTSVIEW | A_SALESVIEW,
            R_GERENT        =   1<<14 | R_REPOSITOR | R_SELLER | R_AUDITOR | A_SALESCHANGE
        }
        public class User
        {
            public string Name { get; set; }
            public UserGrants Grants { get; set; }
            public User(String Name="Desconocido" , UserGrants Grants=UserGrants.R_NONE)
            {
                this.Name = Name;
                this.Grants = Grants;
            }
        }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}