using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using WebApplication1.comment;
using WebApplication1.group;
using WebApplication1.idol;
using WebApplication1.user;

namespace WebApplication1.shared.infrastructure;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<User, IdentityRole<Guid>, Guid>(options)
{
 public DbSet<Idol> Idols { get; init; }
 public DbSet<Group> Groups { get; init; }
 public DbSet<Comment> Comments { get; init; }

 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
  optionsBuilder.ConfigureWarnings(warnings =>
   warnings.Ignore(RelationalEventId.PendingModelChangesWarning));

  base.OnConfiguring(optionsBuilder);
 }

 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
  base.OnModelCreating(modelBuilder);

  modelBuilder.Entity<User>(entity =>
  {
   entity.Property(e => e.Initials).HasMaxLength(5);
  });

  modelBuilder.HasDefaultSchema("identity");

  var aespaId = Guid.NewGuid();
  var newJeansId = Guid.NewGuid();

  modelBuilder.Entity<Group>(entity =>
  {
   entity.HasKey(e => e.Id);
   entity.Property(e => e.Name).IsRequired();
   entity.Property(e => e.Description).IsRequired();
   entity.Property(e => e.Photo).IsRequired();

   entity.HasData(new Group(
    Id: aespaId,
    Name: "aespa",
    Description: "aespa is a 4-member girl group (Karina, Giselle, Winter, Ningning) from SM Entertainment that debuted on Nov 17th, 2020 with \"Black Mamba.\"\n\nLargely thought to be one of the groups that “started the 4th gen of K-Pop,” aespa is recognized for their theme of AIs and virtual reality. Throughout their album art, lyrics, music videos, and concept films, aespa has established unique lore of their own, drawing inspiration from sub-culture genres such as cyberpunk and frutiger aero, reminiscent of the Y2K trend.\n\naespa’s discography spans a variety of genres - including electronica, synthpop, hyperpop, trap, hiphop, R&B, and more.",
    Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/GNEEkD4bgAASBoV.jpg"
   ),
    new Group(
     Id: newJeansId,
     Name: "New Jeans",
     Description: "NewJeans is a 5-member girl group (Minji, Hanni, Danielle, Haerin, Hyein) from ADOR that debuted on July 22nd, 2022 with “Attention.” \n\nOne of the most successful groups of the 4th generation of K-Pop, NewJeans is thought to have brought back the “easy listening” genre back to K-Pop, as well as popularizing the visual trend of the “girl next door” and “y2k concept” in the industry. NewJeans is known for their “natural” image; choosing minimalism over maximalism, or the typical level of “hyperproduction” in K-Pop. Super high notes, frantic beat changes, punchy rap verses, and super-synchronized dance routines are mostly absent from NewJeans’ hits.\n\nNewJeans is also loved for their “nostalgic” image and sound, blending mellow mid-tempo pop and R&B sounds with Jersey Club or Balitimore Club genre. Their overall concept has been called reminiscent of groups such as S.E.S, SPEED, and TLC.\n\nNewJeans is considered to be one of the major fashion icons in the K-Pop industry, with their signature “natural” look with minimal makeup and straight black hair which eventually branched out to other trends like balletcore and blokecore, coupled with collaborations with many fashion/beauty brands.",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/newjeans.jpeg"
     ));
  });


  modelBuilder.Entity<Idol>(entity =>
  {
   entity.HasKey(e => e.Id);
   entity.HasOne<Group>()
    .WithMany()
    .HasForeignKey(e => e.GroupId);
   entity.Property(e => e.Name).IsRequired();
   entity.Property(e => e.RealName).IsRequired();
   entity.Property(e => e.About).IsRequired();
   entity.Property(e => e.Photo).IsRequired();

   entity.HasData(
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: aespaId,
     Name: "Karina",
     RealName: "Yoo Ji-min",
     About: "Karina was scouted by an SM Entertainment casting manager through Instagram and trained for 4 years before her debut in 2020.\n\nKarina said that she started dreaming of becoming a K-Pop idol when she first saw the famous “kick” choreography from \"Into the New World\" by Girls’ Generation (also a group under SM Entertainment) back in 2007, when she was in the first grade of elementary school.\n\nAs a trainee of SM Entertainment, Karina made an appearance in the music video for labelmate Taemin’s \"Want\" in 2019 and also performed with him on music programs.",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/krn.jpeg"
    ),
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: aespaId,
     Name: "Giselle",
     RealName: "Aeri Uchinaga",
     About: "Giselle was born in South Korea to a Japanese father and a Korean mother. She attended an international school with an American curriculum in Japan, so she can speak Japanese, Korean, and English fluently. Giselle has said she feels the most comfortable with English and has used Korean mostly with her mother pre-debut.\n\nShe was of both Korean and Japanese nationality until she turned 22. Afterward, she chose the Japanese nationality as Japan does not allow one to possess dual nationalities.\n\nGiselle sang \"Cherry Bomb\" by NCT 127 in the infamous “Saturday Open Auditions” of SM Entertainment and got accepted as a trainee. After graduating high school in Japan, she has come to Korea specifically for the purpose of getting into SM Entertainment and becoming a K-Pop idol, and has auditioned 4 times for SM Entertainment alone.\n\nGiselle was a trainee for 11 months in SM Entertainment from the age of 19, from December 2019. Her time as a trainee before her debut is the shortest among all female artists from SM Entertainment. Her stage name, “Giselle,” was chosen because, as a trainee, she used to wear headbands a lot and had a very “elegant” image.\n\nGiselle’s debut teaser was released on the day of Giselle’s birthday. In the video, she raps in 3 languages - Korean, Japanese, and English.",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/gs.jpeg"
    ),
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: aespaId,
     Name: "Winter",
     RealName: "Kim Min-jeong",
     About: "Winter had wanted to become an idol singer since middle school and was a member of a K-Pop dance club at her school.\n\nIn 2016, Winter was scouted by an SM Entertainment casting manager at a dance festival in Yangsan, her hometown in Gyeongsangnam-do, South Korea, when she was 15 years old. She trained for 4 years before her debut in 2020.",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/wt.jpeg"
    ),
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: aespaId,
     Name: "Ningning",
     RealName: "Níng Yìzhuó",
     About: "Prior to debuting in Korea as a K-Pop artist, Ningning appeared on many audition programs in China, her home country. In March 2011, she entered the preliminary rounds of China’s Got Talent - Season 2 and sang a song by Jolin Tsai, often dubbed the “Queen of Chinese Pop.” In 2013, she has also performed in front of 50,000 audiences in 加油！少年派 and received the nickname “Little Joline Tsai.” She consistently appeared on Chinese audition programs until 2016, notably performing \"Shake It\" by SISTAR, a K-Pop girl group, in 2015.\n\nOn September 19th, 2016, Ningning was revealed to be one of the SMROOKIES members, a pre-debut team of trainees organized by SM Entertainment. For 10 episodes starting in September 19th, 2016, Ningning has starred as a regular member in MY SMT Rookies Princess - ‘Who’s the Best’. She was the only SMROOKIES member to stay until 2020, before her debut as a member of aespa.\n\nEven though she is the youngest member of her team, her time as a trainee (4 years and 2 months) is the longest among the group members.",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/nn.jpeg"
    ),
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: newJeansId,
     Name: "Minji",
     RealName: "Kim Min-ji",
     About: "Minji was born in Chuncheon, South Korea and lived there until her first year of middle school (7th grade). She went on a “home-stay camp” to Canada for a few months when she was in elementary school, and became fluent in English. Minji had originally studied to become a student in a Foreign Languages High School student, until she started learning guitar in an academy and the teacher recommended her to participate in the in-academy audition held by Source Music.\n\nMinji danced to “SIGNAL” by TWICE in the audition and became an official trainee of Source Music in 2017.\n\nAfter becoming a trainee, Minji transferred to a middle school in Seoul. She was first a trainee of Source Music, and later of ADOR (both sub-labels under HYBE). She was selected as the first trainee to join ADOR’s first-ever girl group. In 2019, Minji appeared in the poster and video advertisement for PLUS GLOBAL AUDITION by HYBE.\n\nIn 2021, Minji appeared in the music video for “Permission to Dance” by BTS with Hanni.\n\nMinji was a trainee for approximately four and a half years before debut.",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_21.jpg"
    ),
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: newJeansId,
     Name: "Hanni",
     RealName: "Hanni Pham",
     About: "Hanni was born and raised in Melbourne, Australia to Vietnamese-Australian parents. Hanni is a third-generation Vietnamese-Australian, and her first language is English. Hanni has learned taekwondo, a Korean martial arts sport when she was younger, as her grandfather owns a taekwondo academy in Australia. In 2014, Hanni entered The Voice Kids Australia and sang a song by One Direction, who she had been a fan of.\n\nIn 2019, Hanni was active as a member of K-Pop cover dance team, “Aemina” with Vietnamese-Australian friends in Melbourne. In October 2019, Hanni auditioned at the Melbourne global auditions held by Source Music, singing “Would you be so kind” by Dodie Clark and playing ukuelele to accompany the song. She first became a trainee of Source Music, and later of ADOR (both sub-labels under HYBE).\n\nIn 2021, Hanni appeared in the music video for “Permission to Dance” by BTS with Minji.\n\nHanni was a trainee for approximatly two and a half years before debut.",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_19.jpg"
    ),
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: newJeansId,
     Name: "Danielle",
     RealName: "Danielle June Marsh",
     About: "Danielle was born in Australia to an Australian father and Korean mother. She came back to Korea when she was 4 years old and lived for about 3 years, where she learned to speak Korean. From 2010 to 2012, Danielle was a kid model in Korea, filming various ads and going on kids’ shows such as Rainbow Kindergarten, Jesse’s Play Kitchen, My Heart’s Crayon, Hello Yoga Kids, Shinhwa TV, Ding Dong Dang Kindergarten, and more. She has won multiple awards for kids’ model competitions in 2011.\n\nDanielle returned to Australia in 2012 and went to school in Australia. In 2016, Danielle was one of the cast members in the Matilda musical production in Australia. In 2018, Danielle entered the Young Artist Festival in Sydney, singing “Sitting On Top of the World” by Delta Goodrem, and won the popularity vote from the audience.\n\nIn 2020, Danielle auditioned for HYBE by singing “Best Part” by Daniel Caesar. She first became a trainee of Source Music, and later of ADOR (both sub-labels under HYBE). She trained for two and a half years before debut.",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_31-1.jpg"
    ),
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: newJeansId,
     Name: "Haerin",
     RealName: "Kang Haerin",
     About: "Haerin was a member of the broadcasting club at her elementary school, and had been offered casting by casting managers on the street several times. She was born in Seoul but mostly grew up in Anyang and went to a dance academy there. In 2020, Haerin auditioned at HYBE, singing a song by BOL4 and became a trainee of Source Music, and later of ADOR (both sub-labels under HYBE). She trained for two and a half years before debut.",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_26-1.jpg"
    ),
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: newJeansId,
     Name: "Hyein",
     RealName: "Lee Hye-in",
     About: "Prior to debut, Hyein was a kid model/entertainer. Hyein was the brand model for various brands such as Tara N Co, Moximoxi, Emart Nobrand, and PRANKERS. Hyein was one of the models for the clothing brand Kipop launched by ON1 ENT, and attended the 18F/W Seoul Fashion Week. In 2019, Hyein won the Daesang (main award) for 2019 Little The Look of The Year, a competition for kid models. In 2020, Hyein was on the runway of 2020 Mercedes Benz Fashion Week.\n\nFrom 2017 to 2018, Hyein was a member of the kid idol group U.SSO Girls managed by ON1 ENT, under the stage name Ujeong. Hyein was active as a member of U.SSO Girls along with Rora of BABYMONSTER.\n\nFrom 2019 to 2021, Hyein was one of the starting members of Play With Me Club on the YouTube channel Pocket TV (managed under Daekyo Children’s TV), filming variety-style content, vlogs, and mock K-Pop idol auditions. Hyein played the female lead on the kids’ web drama series The Girl’s Double Life.\n\nIn 2020, Hyein was one of the “Boni Hani” crew on the Live Broadcast Talk! Talk! Boni Hani, a kids’ variety show under EBS.\n\nIn 2021, Hyein auditioned at ADOR, dancing to “Lovesick Girls” by BLACKPINK and became a trainee of ADOR. She was the last member to join the debut team that would later become NewJeans. Hyein trained for a year and two months before debut.",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_03.jpg"
    )
   );
  });

  modelBuilder.Entity<Comment>(entity =>
  {
   entity.HasKey(e => e.Id);
   entity.HasOne<Group>()
    .WithMany()
    .HasForeignKey(e => e.GroupId);
   entity.HasOne<User>()
    .WithMany()
    .HasForeignKey(e => e.AuthorId);
   entity.Property(e => e.Content).IsRequired();
   entity.Property(e => e.CreatedAt).IsRequired();
   entity.Property(e => e.UpdatedAt);
  });
 }
}
