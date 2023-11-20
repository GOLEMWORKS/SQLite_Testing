using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SQLite.MainApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Avatar", "Department", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "https://robohash.org/autautea.png?size=100x100&set=set1", "Research and Development", "nmorgue0@disqus.com", "Nonie", "Morgue" },
                    { 2, "https://robohash.org/saepeadipiscifugit.png?size=100x100&set=set1", "Research and Development", "klowe1@nymag.com", "Krishna", "Lowe" },
                    { 3, "https://robohash.org/atquerepudiandaecorporis.png?size=100x100&set=set1", "Research and Development", "owilliamson2@washingtonpost.com", "Orville", "Williamson" },
                    { 4, "https://robohash.org/liberotemporibusalias.png?size=100x100&set=set1", "Product Management", "ditzkovici3@phpbb.com", "Dwayne", "Itzkovici" },
                    { 5, "https://robohash.org/enimsapienteillum.png?size=100x100&set=set1", "Research and Development", "sjerisch4@craigslist.org", "Shelbi", "Jerisch" },
                    { 6, "https://robohash.org/omnisillumnostrum.png?size=100x100&set=set1", "Services", "jwitcherley5@1und1.de", "Jerrilee", "Witcherley" },
                    { 7, "https://robohash.org/adipiscisequidolor.png?size=100x100&set=set1", "Marketing", "ckobpac6@goo.ne.jp", "Caritta", "Kobpac" },
                    { 8, "https://robohash.org/aliquamquassunt.png?size=100x100&set=set1", "Human Resources", "qmccague7@facebook.com", "Quincey", "McCague" },
                    { 9, "https://robohash.org/eaquiserror.png?size=100x100&set=set1", "Accounting", "acundey8@yahoo.com", "Aharon", "Cundey" },
                    { 10, "https://robohash.org/dolorconsecteturdeleniti.png?size=100x100&set=set1", "Services", "nanthill9@posterous.com", "Neila", "Anthill" },
                    { 11, "https://robohash.org/veroculpadolore.png?size=100x100&set=set1", "Business Development", "cbroadera@theglobeandmail.com", "Cinnamon", "Broader" },
                    { 12, "https://robohash.org/autveritatisquibusdam.png?size=100x100&set=set1", "Business Development", "gtampinb@example.com", "Godfrey", "Tampin" },
                    { 13, "https://robohash.org/utvoluptasdolorum.png?size=100x100&set=set1", "Support", "oandrellic@t-online.de", "Olimpia", "Andrelli" },
                    { 14, "https://robohash.org/odioinqui.png?size=100x100&set=set1", "Human Resources", "gebblesd@fema.gov", "Grissel", "Ebbles" },
                    { 15, "https://robohash.org/saepedelenitivoluptas.png?size=100x100&set=set1", "Sales", "bsutherleye@bing.com", "Beckie", "Sutherley" },
                    { 16, "https://robohash.org/aspernaturautdicta.png?size=100x100&set=set1", "Sales", "dschohierf@dion.ne.jp", "Drusie", "Schohier" },
                    { 17, "https://robohash.org/dolornobisratione.png?size=100x100&set=set1", "Sales", "aheisterg@soup.io", "Aida", "Heister" },
                    { 18, "https://robohash.org/estnihilsuscipit.png?size=100x100&set=set1", "Services", "vleakeh@umn.edu", "Valentia", "Leake" },
                    { 19, "https://robohash.org/abperspiciatismagnam.png?size=100x100&set=set1", "Training", "ogellatelyi@spotify.com", "Octavius", "Gellately" },
                    { 20, "https://robohash.org/blanditiisvoluptasrerum.png?size=100x100&set=set1", "Product Management", "emandyj@webs.com", "Erwin", "Mandy" },
                    { 21, "https://robohash.org/auteavel.png?size=100x100&set=set1", "Engineering", "adevenportk@google.fr", "Armand", "Devenport" },
                    { 22, "https://robohash.org/consequuntureveniethic.png?size=100x100&set=set1", "Research and Development", "btorell@mit.edu", "Bartel", "Torel" },
                    { 23, "https://robohash.org/fugitmagnamhic.png?size=100x100&set=set1", "Research and Development", "aludgatem@ning.com", "Auberta", "Ludgate" },
                    { 24, "https://robohash.org/voluptatumetet.png?size=100x100&set=set1", "Support", "csendalln@bizjournals.com", "Claudian", "Sendall" },
                    { 25, "https://robohash.org/cupiditateestsoluta.png?size=100x100&set=set1", "Engineering", "sdarrello@auda.org.au", "Saw", "Darrell" },
                    { 26, "https://robohash.org/quosconsequaturqui.png?size=100x100&set=set1", "Research and Development", "anarracottp@dedecms.com", "Arv", "Narracott" },
                    { 27, "https://robohash.org/temporibusperspiciatiscommodi.png?size=100x100&set=set1", "Sales", "scloustonq@ow.ly", "Silvia", "Clouston" },
                    { 28, "https://robohash.org/eoseosdoloremque.png?size=100x100&set=set1", "Support", "fartistr@fda.gov", "Fabio", "Artist" },
                    { 29, "https://robohash.org/nihiloptiout.png?size=100x100&set=set1", "Sales", "elents@wikimedia.org", "Eldredge", "Lent" },
                    { 30, "https://robohash.org/solutaarchitectovoluptate.png?size=100x100&set=set1", "Business Development", "agoodlettt@yellowbook.com", "Arlin", "Goodlett" },
                    { 31, "https://robohash.org/teneturquidemexercitationem.png?size=100x100&set=set1", "Legal", "fkeyseu@mac.com", "Fenelia", "Keyse" },
                    { 32, "https://robohash.org/eligenditotamdelectus.png?size=100x100&set=set1", "Training", "mshawlv@is.gd", "Merilyn", "Shawl" },
                    { 33, "https://robohash.org/dolorevoluptatibusaut.png?size=100x100&set=set1", "Accounting", "mwadelinw@bravesites.com", "Maryellen", "Wadelin" },
                    { 34, "https://robohash.org/delenitiomnisperferendis.png?size=100x100&set=set1", "Sales", "bvanyukovx@vinaora.com", "Blondie", "Vanyukov" },
                    { 35, "https://robohash.org/nostrumharumeveniet.png?size=100x100&set=set1", "Engineering", "lliccardoy@unicef.org", "Leon", "Liccardo" },
                    { 36, "https://robohash.org/corporisquibusdamnisi.png?size=100x100&set=set1", "Engineering", "tburneyz@mac.com", "Theodosia", "Burney" },
                    { 37, "https://robohash.org/laudantiumillorepellendus.png?size=100x100&set=set1", "Accounting", "tbenedyktowicz10@indiatimes.com", "Tiffany", "Benedyktowicz" },
                    { 38, "https://robohash.org/similiquerepellatitaque.png?size=100x100&set=set1", "Business Development", "swathey11@fc2.com", "Salomon", "Wathey" },
                    { 39, "https://robohash.org/utmaximeet.png?size=100x100&set=set1", "Sales", "fmeineking12@cbsnews.com", "Fidelio", "Meineking" },
                    { 40, "https://robohash.org/doloresomnisaut.png?size=100x100&set=set1", "Support", "fdemicoli13@earthlink.net", "Ford", "De Micoli" },
                    { 41, "https://robohash.org/nostrumdoloremqueillum.png?size=100x100&set=set1", "Accounting", "bstebbings14@bbc.co.uk", "Bridie", "Stebbings" },
                    { 42, "https://robohash.org/porroenimdolorem.png?size=100x100&set=set1", "Business Development", "tkarpets15@cmu.edu", "Theressa", "Karpets" },
                    { 43, "https://robohash.org/earumquiaest.png?size=100x100&set=set1", "Services", "tleivesley16@prlog.org", "Twyla", "Leivesley" },
                    { 44, "https://robohash.org/voluptatevoluptatemexcepturi.png?size=100x100&set=set1", "Product Management", "acroney17@purevolume.com", "Alane", "Croney" },
                    { 45, "https://robohash.org/possimusvoluptatesquas.png?size=100x100&set=set1", "Sales", "aurrey18@seesaa.net", "Althea", "Urrey" },
                    { 46, "https://robohash.org/magnamaliasveritatis.png?size=100x100&set=set1", "Business Development", "dphifer19@yale.edu", "Desiri", "Phifer" },
                    { 47, "https://robohash.org/idquaesint.png?size=100x100&set=set1", "Services", "cmeecher1a@walmart.com", "Cicily", "Meecher" },
                    { 48, "https://robohash.org/magnipariaturdolor.png?size=100x100&set=set1", "Business Development", "hupstone1b@bloglines.com", "Harriott", "Upstone" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }
    }
}
