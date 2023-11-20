using Microsoft.EntityFrameworkCore;

namespace SQLite.MainApp.Data
{
    public class EmployeeDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public EmployeeDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("DatabaseMain"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .ToTable("Employee");

            modelBuilder.Entity<Employee>()
                .HasData(
                    new Employee { Id = 1, FirstName = "Nonie", LastName = "Morgue", Email = "nmorgue0@disqus.com", Department = "Research and Development", Avatar = "https://robohash.org/autautea.png?size=100x100&set=set1" },
                    new Employee { Id = 2, FirstName = "Krishna", LastName = "Lowe", Email = "klowe1@nymag.com", Department = "Research and Development", Avatar = "https://robohash.org/saepeadipiscifugit.png?size=100x100&set=set1" },
                    new Employee { Id = 3, FirstName = "Orville", LastName = "Williamson", Email = "owilliamson2@washingtonpost.com", Department = "Research and Development", Avatar = "https://robohash.org/atquerepudiandaecorporis.png?size=100x100&set=set1" },
                    new Employee { Id = 4, FirstName = "Dwayne", LastName = "Itzkovici", Email = "ditzkovici3@phpbb.com", Department = "Product Management", Avatar = "https://robohash.org/liberotemporibusalias.png?size=100x100&set=set1" },
                    new Employee { Id = 5, FirstName = "Shelbi", LastName = "Jerisch", Email = "sjerisch4@craigslist.org", Department = "Research and Development", Avatar = "https://robohash.org/enimsapienteillum.png?size=100x100&set=set1" },
                    new Employee { Id = 6, FirstName = "Jerrilee", LastName = "Witcherley", Email = "jwitcherley5@1und1.de", Department = "Services", Avatar = "https://robohash.org/omnisillumnostrum.png?size=100x100&set=set1" },
                    new Employee { Id = 7, FirstName = "Caritta", LastName = "Kobpac", Email = "ckobpac6@goo.ne.jp", Department = "Marketing", Avatar = "https://robohash.org/adipiscisequidolor.png?size=100x100&set=set1" },
                    new Employee { Id = 8, FirstName = "Quincey", LastName = "McCague", Email = "qmccague7@facebook.com", Department = "Human Resources", Avatar = "https://robohash.org/aliquamquassunt.png?size=100x100&set=set1" },
                    new Employee { Id = 9, FirstName = "Aharon", LastName = "Cundey", Email = "acundey8@yahoo.com", Department = "Accounting", Avatar = "https://robohash.org/eaquiserror.png?size=100x100&set=set1" },
                    new Employee { Id = 10, FirstName = "Neila", LastName = "Anthill", Email = "nanthill9@posterous.com", Department = "Services", Avatar = "https://robohash.org/dolorconsecteturdeleniti.png?size=100x100&set=set1" },
                    new Employee { Id = 11, FirstName = "Cinnamon", LastName = "Broader", Email = "cbroadera@theglobeandmail.com", Department = "Business Development", Avatar = "https://robohash.org/veroculpadolore.png?size=100x100&set=set1" },
                    new Employee { Id = 12, FirstName = "Godfrey", LastName = "Tampin", Email = "gtampinb@example.com", Department = "Business Development", Avatar = "https://robohash.org/autveritatisquibusdam.png?size=100x100&set=set1" },
                    new Employee { Id = 13, FirstName = "Olimpia", LastName = "Andrelli", Email = "oandrellic@t-online.de", Department = "Support", Avatar = "https://robohash.org/utvoluptasdolorum.png?size=100x100&set=set1" },
                    new Employee { Id = 14, FirstName = "Grissel", LastName = "Ebbles", Email = "gebblesd@fema.gov", Department = "Human Resources", Avatar = "https://robohash.org/odioinqui.png?size=100x100&set=set1" },
                    new Employee { Id = 15, FirstName = "Beckie", LastName = "Sutherley", Email = "bsutherleye@bing.com", Department = "Sales", Avatar = "https://robohash.org/saepedelenitivoluptas.png?size=100x100&set=set1" },
                    new Employee { Id = 16, FirstName = "Drusie", LastName = "Schohier", Email = "dschohierf@dion.ne.jp", Department = "Sales", Avatar = "https://robohash.org/aspernaturautdicta.png?size=100x100&set=set1" },
                    new Employee { Id = 17, FirstName = "Aida", LastName = "Heister", Email = "aheisterg@soup.io", Department = "Sales", Avatar = "https://robohash.org/dolornobisratione.png?size=100x100&set=set1" },
                    new Employee { Id = 18, FirstName = "Valentia", LastName = "Leake", Email = "vleakeh@umn.edu", Department = "Services", Avatar = "https://robohash.org/estnihilsuscipit.png?size=100x100&set=set1" },
                    new Employee { Id = 19, FirstName = "Octavius", LastName = "Gellately", Email = "ogellatelyi@spotify.com", Department = "Training", Avatar = "https://robohash.org/abperspiciatismagnam.png?size=100x100&set=set1" },
                    new Employee { Id = 20, FirstName = "Erwin", LastName = "Mandy", Email = "emandyj@webs.com", Department = "Product Management", Avatar = "https://robohash.org/blanditiisvoluptasrerum.png?size=100x100&set=set1" },
                    new Employee { Id = 21, FirstName = "Armand", LastName = "Devenport", Email = "adevenportk@google.fr", Department = "Engineering", Avatar = "https://robohash.org/auteavel.png?size=100x100&set=set1" },
                    new Employee { Id = 22, FirstName = "Bartel", LastName = "Torel", Email = "btorell@mit.edu", Department = "Research and Development", Avatar = "https://robohash.org/consequuntureveniethic.png?size=100x100&set=set1" },
                    new Employee { Id = 23, FirstName = "Auberta", LastName = "Ludgate", Email = "aludgatem@ning.com", Department = "Research and Development", Avatar = "https://robohash.org/fugitmagnamhic.png?size=100x100&set=set1" },
                    new Employee { Id = 24, FirstName = "Claudian", LastName = "Sendall", Email = "csendalln@bizjournals.com", Department = "Support", Avatar = "https://robohash.org/voluptatumetet.png?size=100x100&set=set1" },
                    new Employee { Id = 25, FirstName = "Saw", LastName = "Darrell", Email = "sdarrello@auda.org.au", Department = "Engineering", Avatar = "https://robohash.org/cupiditateestsoluta.png?size=100x100&set=set1" },
                    new Employee { Id = 26, FirstName = "Arv", LastName = "Narracott", Email = "anarracottp@dedecms.com", Department = "Research and Development", Avatar = "https://robohash.org/quosconsequaturqui.png?size=100x100&set=set1" },
                    new Employee { Id = 27, FirstName = "Silvia", LastName = "Clouston", Email = "scloustonq@ow.ly", Department = "Sales", Avatar = "https://robohash.org/temporibusperspiciatiscommodi.png?size=100x100&set=set1" },
                    new Employee { Id = 28, FirstName = "Fabio", LastName = "Artist", Email = "fartistr@fda.gov", Department = "Support", Avatar = "https://robohash.org/eoseosdoloremque.png?size=100x100&set=set1" },
                    new Employee { Id = 29, FirstName = "Eldredge", LastName = "Lent", Email = "elents@wikimedia.org", Department = "Sales", Avatar = "https://robohash.org/nihiloptiout.png?size=100x100&set=set1" },
                    new Employee { Id = 30, FirstName = "Arlin", LastName = "Goodlett", Email = "agoodlettt@yellowbook.com", Department = "Business Development", Avatar = "https://robohash.org/solutaarchitectovoluptate.png?size=100x100&set=set1" },
                    new Employee { Id = 31, FirstName = "Fenelia", LastName = "Keyse", Email = "fkeyseu@mac.com", Department = "Legal", Avatar = "https://robohash.org/teneturquidemexercitationem.png?size=100x100&set=set1" },
                    new Employee { Id = 32, FirstName = "Merilyn", LastName = "Shawl", Email = "mshawlv@is.gd", Department = "Training", Avatar = "https://robohash.org/eligenditotamdelectus.png?size=100x100&set=set1" },
                    new Employee { Id = 33, FirstName = "Maryellen", LastName = "Wadelin", Email = "mwadelinw@bravesites.com", Department = "Accounting", Avatar = "https://robohash.org/dolorevoluptatibusaut.png?size=100x100&set=set1" },
                    new Employee { Id = 34, FirstName = "Blondie", LastName = "Vanyukov", Email = "bvanyukovx@vinaora.com", Department = "Sales", Avatar = "https://robohash.org/delenitiomnisperferendis.png?size=100x100&set=set1" },
                    new Employee { Id = 35, FirstName = "Leon", LastName = "Liccardo", Email = "lliccardoy@unicef.org", Department = "Engineering", Avatar = "https://robohash.org/nostrumharumeveniet.png?size=100x100&set=set1" },
                    new Employee { Id = 36, FirstName = "Theodosia", LastName = "Burney", Email = "tburneyz@mac.com", Department = "Engineering", Avatar = "https://robohash.org/corporisquibusdamnisi.png?size=100x100&set=set1" },
                    new Employee { Id = 37, FirstName = "Tiffany", LastName = "Benedyktowicz", Email = "tbenedyktowicz10@indiatimes.com", Department = "Accounting", Avatar = "https://robohash.org/laudantiumillorepellendus.png?size=100x100&set=set1" },
                    new Employee { Id = 38, FirstName = "Salomon", LastName = "Wathey", Email = "swathey11@fc2.com", Department = "Business Development", Avatar = "https://robohash.org/similiquerepellatitaque.png?size=100x100&set=set1" },
                    new Employee { Id = 39, FirstName = "Fidelio", LastName = "Meineking", Email = "fmeineking12@cbsnews.com", Department = "Sales", Avatar = "https://robohash.org/utmaximeet.png?size=100x100&set=set1" },
                    new Employee { Id = 40, FirstName = "Ford", LastName = "De Micoli", Email = "fdemicoli13@earthlink.net", Department = "Support", Avatar = "https://robohash.org/doloresomnisaut.png?size=100x100&set=set1" },
                    new Employee { Id = 41, FirstName = "Bridie", LastName = "Stebbings", Email = "bstebbings14@bbc.co.uk", Department = "Accounting", Avatar = "https://robohash.org/nostrumdoloremqueillum.png?size=100x100&set=set1" },
                    new Employee { Id = 42, FirstName = "Theressa", LastName = "Karpets", Email = "tkarpets15@cmu.edu", Department = "Business Development", Avatar = "https://robohash.org/porroenimdolorem.png?size=100x100&set=set1" },
                    new Employee { Id = 43, FirstName = "Twyla", LastName = "Leivesley", Email = "tleivesley16@prlog.org", Department = "Services", Avatar = "https://robohash.org/earumquiaest.png?size=100x100&set=set1" },
                    new Employee { Id = 44, FirstName = "Alane", LastName = "Croney", Email = "acroney17@purevolume.com", Department = "Product Management", Avatar = "https://robohash.org/voluptatevoluptatemexcepturi.png?size=100x100&set=set1" },
                    new Employee { Id = 45, FirstName = "Althea", LastName = "Urrey", Email = "aurrey18@seesaa.net", Department = "Sales", Avatar = "https://robohash.org/possimusvoluptatesquas.png?size=100x100&set=set1" },
                    new Employee { Id = 46, FirstName = "Desiri", LastName = "Phifer", Email = "dphifer19@yale.edu", Department = "Business Development", Avatar = "https://robohash.org/magnamaliasveritatis.png?size=100x100&set=set1" },
                    new Employee { Id = 47, FirstName = "Cicily", LastName = "Meecher", Email = "cmeecher1a@walmart.com", Department = "Services", Avatar = "https://robohash.org/idquaesint.png?size=100x100&set=set1" },
                    new Employee { Id = 48, FirstName = "Harriott", LastName = "Upstone", Email = "hupstone1b@bloglines.com", Department = "Business Development", Avatar = "https://robohash.org/magnipariaturdolor.png?size=100x100&set=set1" }
                    );
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
