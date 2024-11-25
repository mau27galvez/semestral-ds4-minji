using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AddIdolAbout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("2064191a-84d2-444e-a4a5-07f1779ec367"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("6eda3695-ccc5-42c3-8ec7-da59e80c65ca"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("7ea37698-fd30-45bb-a9c2-73d4eff5aa3e"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("7ed381a8-d612-4eb2-a535-2194ccdce8f8"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("80cc5465-fcd2-47b5-8e89-682d7bc6eba2"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("a700cd97-caf2-4dde-84ab-87b381f417a8"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("cbfadc0b-875c-4ad2-b612-a184d9bcbbf9"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("d3e4a0d2-7679-4bc5-9b4f-d811ea85a6ad"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("ee0ff8af-a21e-4dcf-b67a-3448f56acecf"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ac871e35-16c6-4124-90f4-e78c22d367f6"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("dbce17d4-aee8-4fb9-9951-c689e5a8aa44"));

            migrationBuilder.AddColumn<string>(
                name: "About",
                schema: "identity",
                table: "Idols",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Groups",
                columns: new[] { "Id", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { new Guid("0d1f86b1-f330-4077-817a-d31a54345ab2"), "NewJeans is a 5-member girl group (Minji, Hanni, Danielle, Haerin, Hyein) from ADOR that debuted on July 22nd, 2022 with “Attention.” \n\nOne of the most successful groups of the 4th generation of K-Pop, NewJeans is thought to have brought back the “easy listening” genre back to K-Pop, as well as popularizing the visual trend of the “girl next door” and “y2k concept” in the industry. NewJeans is known for their “natural” image; choosing minimalism over maximalism, or the typical level of “hyperproduction” in K-Pop. Super high notes, frantic beat changes, punchy rap verses, and super-synchronized dance routines are mostly absent from NewJeans’ hits.\n\nNewJeans is also loved for their “nostalgic” image and sound, blending mellow mid-tempo pop and R&B sounds with Jersey Club or Balitimore Club genre. Their overall concept has been called reminiscent of groups such as S.E.S, SPEED, and TLC.\n\nNewJeans is considered to be one of the major fashion icons in the K-Pop industry, with their signature “natural” look with minimal makeup and straight black hair which eventually branched out to other trends like balletcore and blokecore, coupled with collaborations with many fashion/beauty brands.", "New Jeans", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/newjeans.jpeg" },
                    { new Guid("2abfbfa3-7aee-4452-9528-c3e7935e5728"), "aespa is a 4-member girl group (Karina, Giselle, Winter, Ningning) from SM Entertainment that debuted on Nov 17th, 2020 with \"Black Mamba.\"\n\nLargely thought to be one of the groups that “started the 4th gen of K-Pop,” aespa is recognized for their theme of AIs and virtual reality. Throughout their album art, lyrics, music videos, and concept films, aespa has established unique lore of their own, drawing inspiration from sub-culture genres such as cyberpunk and frutiger aero, reminiscent of the Y2K trend.\n\naespa’s discography spans a variety of genres - including electronica, synthpop, hyperpop, trap, hiphop, R&B, and more.", "aespa", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/GNEEkD4bgAASBoV.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Idols",
                columns: new[] { "Id", "About", "GroupId", "Name", "Photo", "RealName" },
                values: new object[,]
                {
                    { new Guid("29bfa914-72e7-4a4a-bea8-f6a41facba05"), "Giselle was born in South Korea to a Japanese father and a Korean mother. She attended an international school with an American curriculum in Japan, so she can speak Japanese, Korean, and English fluently. Giselle has said she feels the most comfortable with English and has used Korean mostly with her mother pre-debut.\n\nShe was of both Korean and Japanese nationality until she turned 22. Afterward, she chose the Japanese nationality as Japan does not allow one to possess dual nationalities.\n\nGiselle sang \"Cherry Bomb\" by NCT 127 in the infamous “Saturday Open Auditions” of SM Entertainment and got accepted as a trainee. After graduating high school in Japan, she has come to Korea specifically for the purpose of getting into SM Entertainment and becoming a K-Pop idol, and has auditioned 4 times for SM Entertainment alone.\n\nGiselle was a trainee for 11 months in SM Entertainment from the age of 19, from December 2019. Her time as a trainee before her debut is the shortest among all female artists from SM Entertainment. Her stage name, “Giselle,” was chosen because, as a trainee, she used to wear headbands a lot and had a very “elegant” image.\n\nGiselle’s debut teaser was released on the day of Giselle’s birthday. In the video, she raps in 3 languages - Korean, Japanese, and English.", new Guid("2abfbfa3-7aee-4452-9528-c3e7935e5728"), "Giselle", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/gs.jpeg", "Aeri Uchinaga" },
                    { new Guid("52979d57-d3f7-4c58-8d73-b58422dea0ec"), "Minji was born in Chuncheon, South Korea and lived there until her first year of middle school (7th grade). She went on a “home-stay camp” to Canada for a few months when she was in elementary school, and became fluent in English. Minji had originally studied to become a student in a Foreign Languages High School student, until she started learning guitar in an academy and the teacher recommended her to participate in the in-academy audition held by Source Music.\n\nMinji danced to “SIGNAL” by TWICE in the audition and became an official trainee of Source Music in 2017.\n\nAfter becoming a trainee, Minji transferred to a middle school in Seoul. She was first a trainee of Source Music, and later of ADOR (both sub-labels under HYBE). She was selected as the first trainee to join ADOR’s first-ever girl group. In 2019, Minji appeared in the poster and video advertisement for PLUS GLOBAL AUDITION by HYBE.\n\nIn 2021, Minji appeared in the music video for “Permission to Dance” by BTS with Hanni.\n\nMinji was a trainee for approximately four and a half years before debut.", new Guid("0d1f86b1-f330-4077-817a-d31a54345ab2"), "Minji", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_21.jpg", "Kim Min-ji" },
                    { new Guid("56b89ccd-7458-4eca-ae5c-4d9c4dc04d6e"), "Hanni was born and raised in Melbourne, Australia to Vietnamese-Australian parents. Hanni is a third-generation Vietnamese-Australian, and her first language is English. Hanni has learned taekwondo, a Korean martial arts sport when she was younger, as her grandfather owns a taekwondo academy in Australia. In 2014, Hanni entered The Voice Kids Australia and sang a song by One Direction, who she had been a fan of.\n\nIn 2019, Hanni was active as a member of K-Pop cover dance team, “Aemina” with Vietnamese-Australian friends in Melbourne. In October 2019, Hanni auditioned at the Melbourne global auditions held by Source Music, singing “Would you be so kind” by Dodie Clark and playing ukuelele to accompany the song. She first became a trainee of Source Music, and later of ADOR (both sub-labels under HYBE).\n\nIn 2021, Hanni appeared in the music video for “Permission to Dance” by BTS with Minji.\n\nHanni was a trainee for approximatly two and a half years before debut.", new Guid("0d1f86b1-f330-4077-817a-d31a54345ab2"), "Hanni", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_19.jpg", "Hanni Pham" },
                    { new Guid("66c0a258-9896-485c-a8b0-ee02d08ad8aa"), "Winter had wanted to become an idol singer since middle school and was a member of a K-Pop dance club at her school.\n\nIn 2016, Winter was scouted by an SM Entertainment casting manager at a dance festival in Yangsan, her hometown in Gyeongsangnam-do, South Korea, when she was 15 years old. She trained for 4 years before her debut in 2020.", new Guid("2abfbfa3-7aee-4452-9528-c3e7935e5728"), "Winter", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/wt.jpeg", "Kim Min-jeong" },
                    { new Guid("a3449f5b-3c8a-4f02-a812-1ba17fd27e48"), "Karina was scouted by an SM Entertainment casting manager through Instagram and trained for 4 years before her debut in 2020.\n\nKarina said that she started dreaming of becoming a K-Pop idol when she first saw the famous “kick” choreography from \"Into the New World\" by Girls’ Generation (also a group under SM Entertainment) back in 2007, when she was in the first grade of elementary school.\n\nAs a trainee of SM Entertainment, Karina made an appearance in the music video for labelmate Taemin’s \"Want\" in 2019 and also performed with him on music programs.", new Guid("2abfbfa3-7aee-4452-9528-c3e7935e5728"), "Karina", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/krn.jpeg", "Yoo Ji-min" },
                    { new Guid("a9afea6d-a2d2-44d1-a67a-d04e0776b2b4"), "Prior to debuting in Korea as a K-Pop artist, Ningning appeared on many audition programs in China, her home country. In March 2011, she entered the preliminary rounds of China’s Got Talent - Season 2 and sang a song by Jolin Tsai, often dubbed the “Queen of Chinese Pop.” In 2013, she has also performed in front of 50,000 audiences in 加油！少年派 and received the nickname “Little Joline Tsai.” She consistently appeared on Chinese audition programs until 2016, notably performing \"Shake It\" by SISTAR, a K-Pop girl group, in 2015.\n\nOn September 19th, 2016, Ningning was revealed to be one of the SMROOKIES members, a pre-debut team of trainees organized by SM Entertainment. For 10 episodes starting in September 19th, 2016, Ningning has starred as a regular member in MY SMT Rookies Princess - ‘Who’s the Best’. She was the only SMROOKIES member to stay until 2020, before her debut as a member of aespa.\n\nEven though she is the youngest member of her team, her time as a trainee (4 years and 2 months) is the longest among the group members.", new Guid("2abfbfa3-7aee-4452-9528-c3e7935e5728"), "Ningning", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/nn.jpeg", "Níng Yìzhuó" },
                    { new Guid("b2c0ff64-ea89-4152-a500-8b4f76bc6960"), "Haerin was a member of the broadcasting club at her elementary school, and had been offered casting by casting managers on the street several times. She was born in Seoul but mostly grew up in Anyang and went to a dance academy there. In 2020, Haerin auditioned at HYBE, singing a song by BOL4 and became a trainee of Source Music, and later of ADOR (both sub-labels under HYBE). She trained for two and a half years before debut.", new Guid("0d1f86b1-f330-4077-817a-d31a54345ab2"), "Haerin", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_26-1.jpg", "Kang Haerin" },
                    { new Guid("c49b3dee-33c4-482f-8736-1bd2be9ddb84"), "Prior to debut, Hyein was a kid model/entertainer. Hyein was the brand model for various brands such as Tara N Co, Moximoxi, Emart Nobrand, and PRANKERS. Hyein was one of the models for the clothing brand Kipop launched by ON1 ENT, and attended the 18F/W Seoul Fashion Week. In 2019, Hyein won the Daesang (main award) for 2019 Little The Look of The Year, a competition for kid models. In 2020, Hyein was on the runway of 2020 Mercedes Benz Fashion Week.\n\nFrom 2017 to 2018, Hyein was a member of the kid idol group U.SSO Girls managed by ON1 ENT, under the stage name Ujeong. Hyein was active as a member of U.SSO Girls along with Rora of BABYMONSTER.\n\nFrom 2019 to 2021, Hyein was one of the starting members of Play With Me Club on the YouTube channel Pocket TV (managed under Daekyo Children’s TV), filming variety-style content, vlogs, and mock K-Pop idol auditions. Hyein played the female lead on the kids’ web drama series The Girl’s Double Life.\n\nIn 2020, Hyein was one of the “Boni Hani” crew on the Live Broadcast Talk! Talk! Boni Hani, a kids’ variety show under EBS.\n\nIn 2021, Hyein auditioned at ADOR, dancing to “Lovesick Girls” by BLACKPINK and became a trainee of ADOR. She was the last member to join the debut team that would later become NewJeans. Hyein trained for a year and two months before debut.", new Guid("0d1f86b1-f330-4077-817a-d31a54345ab2"), "Hyein", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_03.jpg", "Lee Hye-in" },
                    { new Guid("ea481350-4543-42bf-9e46-aef8aef4529d"), "Danielle was born in Australia to an Australian father and Korean mother. She came back to Korea when she was 4 years old and lived for about 3 years, where she learned to speak Korean. From 2010 to 2012, Danielle was a kid model in Korea, filming various ads and going on kids’ shows such as Rainbow Kindergarten, Jesse’s Play Kitchen, My Heart’s Crayon, Hello Yoga Kids, Shinhwa TV, Ding Dong Dang Kindergarten, and more. She has won multiple awards for kids’ model competitions in 2011.\n\nDanielle returned to Australia in 2012 and went to school in Australia. In 2016, Danielle was one of the cast members in the Matilda musical production in Australia. In 2018, Danielle entered the Young Artist Festival in Sydney, singing “Sitting On Top of the World” by Delta Goodrem, and won the popularity vote from the audience.\n\nIn 2020, Danielle auditioned for HYBE by singing “Best Part” by Daniel Caesar. She first became a trainee of Source Music, and later of ADOR (both sub-labels under HYBE). She trained for two and a half years before debut.", new Guid("0d1f86b1-f330-4077-817a-d31a54345ab2"), "Danielle", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_31-1.jpg", "Danielle June Marsh" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("29bfa914-72e7-4a4a-bea8-f6a41facba05"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("52979d57-d3f7-4c58-8d73-b58422dea0ec"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("56b89ccd-7458-4eca-ae5c-4d9c4dc04d6e"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("66c0a258-9896-485c-a8b0-ee02d08ad8aa"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("a3449f5b-3c8a-4f02-a812-1ba17fd27e48"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("a9afea6d-a2d2-44d1-a67a-d04e0776b2b4"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("b2c0ff64-ea89-4152-a500-8b4f76bc6960"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("c49b3dee-33c4-482f-8736-1bd2be9ddb84"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("ea481350-4543-42bf-9e46-aef8aef4529d"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("0d1f86b1-f330-4077-817a-d31a54345ab2"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("2abfbfa3-7aee-4452-9528-c3e7935e5728"));

            migrationBuilder.DropColumn(
                name: "About",
                schema: "identity",
                table: "Idols");

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Groups",
                columns: new[] { "Id", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { new Guid("ac871e35-16c6-4124-90f4-e78c22d367f6"), "NewJeans is a 5-member girl group (Minji, Hanni, Danielle, Haerin, Hyein) from ADOR that debuted on July 22nd, 2022 with “Attention.” \n\nOne of the most successful groups of the 4th generation of K-Pop, NewJeans is thought to have brought back the “easy listening” genre back to K-Pop, as well as popularizing the visual trend of the “girl next door” and “y2k concept” in the industry. NewJeans is known for their “natural” image; choosing minimalism over maximalism, or the typical level of “hyperproduction” in K-Pop. Super high notes, frantic beat changes, punchy rap verses, and super-synchronized dance routines are mostly absent from NewJeans’ hits.\n\nNewJeans is also loved for their “nostalgic” image and sound, blending mellow mid-tempo pop and R&B sounds with Jersey Club or Balitimore Club genre. Their overall concept has been called reminiscent of groups such as S.E.S, SPEED, and TLC.\n\nNewJeans is considered to be one of the major fashion icons in the K-Pop industry, with their signature “natural” look with minimal makeup and straight black hair which eventually branched out to other trends like balletcore and blokecore, coupled with collaborations with many fashion/beauty brands.", "New Jeans", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/newjeans.jpeg" },
                    { new Guid("dbce17d4-aee8-4fb9-9951-c689e5a8aa44"), "aespa is a 4-member girl group (Karina, Giselle, Winter, Ningning) from SM Entertainment that debuted on Nov 17th, 2020 with \"Black Mamba.\"\n\nLargely thought to be one of the groups that “started the 4th gen of K-Pop,” aespa is recognized for their theme of AIs and virtual reality. Throughout their album art, lyrics, music videos, and concept films, aespa has established unique lore of their own, drawing inspiration from sub-culture genres such as cyberpunk and frutiger aero, reminiscent of the Y2K trend.\n\naespa’s discography spans a variety of genres - including electronica, synthpop, hyperpop, trap, hiphop, R&B, and more.", "aespa", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/GNEEkD4bgAASBoV.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Idols",
                columns: new[] { "Id", "GroupId", "Name", "Photo", "RealName" },
                values: new object[,]
                {
                    { new Guid("2064191a-84d2-444e-a4a5-07f1779ec367"), new Guid("ac871e35-16c6-4124-90f4-e78c22d367f6"), "Minji", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_21.jpg", "Kim Min-ji" },
                    { new Guid("6eda3695-ccc5-42c3-8ec7-da59e80c65ca"), new Guid("ac871e35-16c6-4124-90f4-e78c22d367f6"), "Haerin", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_26-1.jpg", "Kang Haerin" },
                    { new Guid("7ea37698-fd30-45bb-a9c2-73d4eff5aa3e"), new Guid("dbce17d4-aee8-4fb9-9951-c689e5a8aa44"), "Winter", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/wt.jpeg", "Kim Min-jeong" },
                    { new Guid("7ed381a8-d612-4eb2-a535-2194ccdce8f8"), new Guid("dbce17d4-aee8-4fb9-9951-c689e5a8aa44"), "Karina", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/krn.jpeg", "Yoo Ji-min" },
                    { new Guid("80cc5465-fcd2-47b5-8e89-682d7bc6eba2"), new Guid("dbce17d4-aee8-4fb9-9951-c689e5a8aa44"), "Giselle", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/gs.jpeg", "Aeri Uchinaga" },
                    { new Guid("a700cd97-caf2-4dde-84ab-87b381f417a8"), new Guid("ac871e35-16c6-4124-90f4-e78c22d367f6"), "Hyein", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_03.jpg", "Lee Hye-in" },
                    { new Guid("cbfadc0b-875c-4ad2-b612-a184d9bcbbf9"), new Guid("ac871e35-16c6-4124-90f4-e78c22d367f6"), "Hanni", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_19.jpg", "Hanni Pham" },
                    { new Guid("d3e4a0d2-7679-4bc5-9b4f-d811ea85a6ad"), new Guid("ac871e35-16c6-4124-90f4-e78c22d367f6"), "Danielle", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_31-1.jpg", "Danielle June Marsh" },
                    { new Guid("ee0ff8af-a21e-4dcf-b67a-3448f56acecf"), new Guid("dbce17d4-aee8-4fb9-9951-c689e5a8aa44"), "Ningning", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/nn.jpeg", "Níng Yìzhuó" }
                });
        }
    }
}
