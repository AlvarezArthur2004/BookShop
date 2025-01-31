using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication4.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Books> Book { get; set;}

        public DbSet<Purchase> Purchases { get; set; }
    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Book.Add(new Books {
                name = "Player's Handbook",
                author = "Artem",
                discription = "The Player’s Handbook is the essential reference for every Dungeons & Dragons roleplayer. " +
                "It contains rules for character creation and advancement, backgrounds and skills, exploration and combat, " +
                "equipment, spells, and much more. Use this book to create exciting characters from among the most iconic D&D races and classes.",
                company = "Tactical Studies Rules",
                source = "../../Content/Books/PlayerHandBook.png",
                price = 49.95,
                rate = 4.85,
                year = 2014,
                purhases = 1032,
                pages = 322,
                ISBN = 0786965606,
                tax = 222
            });
            db.Book.Add(new Books
            {
                name = "Monster Manual",
                author = "Artem",
                discription = "The Monster Manual presents a horde of classic Dungeons " +
                "& Dragons creatures, including dragons, giants, mind flayers, " +
                "and beholders—a monstrous feast for Dungeon Masters ready to challenge " +
                "their players and populate their adventures.",
                company = "Tactical Studies Rules",
                source = "../../Content/Books/MonsterManual.png",
                price = 34.98,
                rate = 4.75,
                year = 2014,
                purhases = 982,
                pages = 352,
                ISBN = 9780786965618,
                tax = 333
            });
            db.Book.Add(new Books
            {
                name = "Dungeon Master's Guide",
                author = "Artem",
                discription = "The Dungeon Master’s Guide provides the inspiration and the " +
                "guidance you need to spark your imagination and create worlds of adventure " +
                "for your players to explore and enjoy.",
                company = "Tactical Studies Rules",
                source = "../../Content/Books/DungeonMasterGuide.png",
                price = 45.99,
                rate = 4.95,
                year = 2014,
                purhases = 678,
                pages = 238,
                ISBN = 9780786965625,
                tax = 238
            });
            db.Book.Add(new Books
            {
                name = "The Rise of The Witcher",
                author = "Benoit Reiner",
                discription = "The Dungeon Master’s Guide provides the inspiration and the " +
                "guidance you need to spark your imagination and create worlds of adventure " +
                "for your players to explore and enjoy.",
                company = "Third Editions",
                source = "../../Content/Books/TheRiseofTheWitcherANewRPGKing.png",
                price = 29.99,
                rate = 4.56,
                year = 2019,
                purhases = 900,
                pages = 240,
                ISBN = 9782377842452,
                tax = 120
            });
            db.Book.Add(new Books
            {
                name = "C++ Programming Language",
                author = "Benoit Reiner",
                discription = "The new C++11 standard allows programmers to express ideas more clearly, simply, and directly, and to write faster, more efficient code. Bjarne Stroustrup, the designer and original implementer of C++, has reorganized, extended, and completely rewritten his definitive reference and tutorial for programmers who want to use C++ most effectively.§ The C++ Programming Language, Fourth Edition, delivers meticulous, richly explained, and integrated coverage of the entire language - its facilities, abstraction mechanisms, standard libraries, and key design techniques. Throughout, Stroustrup presents concise, pure C++11 examples, which have been carefully crafted to clarify both usage and program design. To promote deeper understanding, the author provides extensive cross-references, both within the book and to the ISO standard.§New C++11 coverage includes§Support for concurrency §Regular expressions, resource management pointers, random numbers, and improved containers §General and uniform initialization, simplified for-statements, move semantics, and Unicode support §Lambdas, general constant expressions, control over class defaults, variadic templates, template aliases, and user-defined literals §Compatibility issues §Topics addressed in this comprehensive book include§Basic facilities: type, object, scope, storage, computation fundamentals, and more §Modularity, as supported by namespaces, source files, and exception handling §C++ abstraction, including classes, class hierarchies, and templates in support of a synthesis of traditional programming, object-oriented programming, and generic programming §Standard Library: containers, algorithms, iterators, utilities, strings, stream I/O, locales, numerics, and more §The C++ basic memory model, in depth §This fourth edition makes C++11 thoroughly accessible to programmers moving from C++ or other languages, while introducing insights and techniques that even cutting-edge C++11 programmers will find indispensable.§§This book features an enhanced, layflat binding, which allows the book to stay open more easily when placed on a flat surface. This special binding method - noticeable by a small space inside the spine - also increases durability.§",
                company = "Third Editions",
                source = "../../Content/Books/C.png",
                price = 70.69,
                rate = 4.80,
                year = 2019,
                purhases = 1500,
                pages = 1376,
                ISBN = 9780321563842,
                tax = 111
            });
            db.Book.Add(new Books
            {
                name = "Harry Potter and the Deathly Hallows",
                author = "J. K. Rowling",
                discription = "Rowling's stunning conclusion to her bestselling Harry Potter series is now available in paperback. As a farewell to the series, Deathly Hallows is everything fans of Harry Potter could hope for.--Time.",
                company = "Scholastic Inc.",
                source = "../../Content/Books/HarryPotterandtheDeathlyHallows.png",
                price = 20.99,
                rate = 5.00,
                year = 1997,
                purhases = 3000,
                pages = 784,
                ISBN = 9780545139700,
                tax = 112
            });
            db.Book.Add(new Books
            {
                name = "Angels & Demons",
                author = "Brown, Dan",
                discription = "Angels & Demons careens from enlightening epiphanies to dark truths as the battle between science and religion turns to war. This is the book that started it all: we meet Robert Langdon for the first time, caught up in a race against time to find an apocalyptic time-bomb, planted by an ancient secret society that has surfaced to carry out its ultimate threat: to destroy the Vatican.",
                company = "Transworld Publishers Ltd",
                source = "../../Content/Books/Angels&Demons.png",
                price = 70.69,
                rate = 4.50,
                year = 2006,
                purhases = 1500,
                pages = 736,
                ISBN = 9780743486224,
                tax = 321
            });
            db.Book.Add(new Books
            {
                name = "New Moon",
                author = "Meyer Stephenie",
                discription = "I stuck my finger under the edge of the paper and jerked it under the tape. 'Shoot,' I muttered when the paper sliced my finger. A single drop of blood oozed from the tiny cut. It all happened very quickly then. 'No!' Edward roared ...Dazed and disorientated, I looked up from the bright red blood pulsing out of my arm - and into the fevered eyes of the six suddenly ravenous vampires. For Bella Swan, there is one thing more important than life itself: Edward Cullen. But being in love with a vampire is more dangerous than Bella ever could have imagined. Edward has already rescued Bella from the clutches of an evil vampire but now, as their daring relationship threatens all that is near and dear to them, they realise their troubles may just be beginning ...",
                company = "Transworld Publishers Ltd",
                source = "../../Content/Books/NewMoon.png",
                price = 9.99,
                rate = 4.99,
                year = 2006,
                purhases = 1200,
                pages = 512,
                ISBN = 9781904233886,
                tax = 421
            });
            db.Book.Add(new Books
            {
                name = "Breaking Dawn",
                author = "Meyer Stephenie",
                discription = "Twilight tempted the imagination . . . New Moon made readers thirsty for more . . . Eclipse turned the saga into a worldwide phenomenon . . . And now - the book that everyone has been waiting for . . . Breaking Dawn. In the much anticipated fourth book in Stephenie Meyer's love story, questions will be answered and the fate of Bella and Edward will be revealed.",
                company = "Transworld Publishers Ltd",
                source = "../../Content/Books/BreakingDawn.png",
                price = 24.99,
                rate = 4.50,
                year = 2006,
                purhases = 1550,
                pages = 736,
                ISBN = 9781907410352,
                tax = 84
            });
            db.Book.Add(new Books
            {
                name = "Deception Point",
                author = "Dan Brown",
                discription = "When a NASA satellite discovers an astonishingly rare object buried deep in the Arctic ice, the floundering space agency proclaims a much-needed victory—a victory with profound implications for NASA policy and the impending presidential election. To verify the authenticity of the find, the White House calls upon the skills of intelligence analyst Rachel Sexton. Accompanied by a team of experts, including the charismatic scholar Michael Tolland, Rachel travels to the Arctic and uncovers the unthinkable: evidence of scientific trickery—a bold deception that threatens to plunge the world into controversy. But before she can warn the president, Rachel and Michael are ambushed by a team of assassins. Fleeing for their lives across a desolate and lethal landscape, their only hope for survival is to discover who is behind this masterful plot. The truth, they will learn, is the most shocking deception of all.",
                company = "Transworld Publishers Ltd",
                source = "../../Content/Books/DeceptionPOINT.png",
                price = 14.99,
                rate = 4.13,
                year = 2006,
                purhases = 1512,
                pages = 464,
                ISBN = 9780743497466,
                tax = 400
            });
            db.Book.Add(new Books
            {
                name = "The Broker",
                author = "John Grisham",
                discription = "With 14 years left on a 20-year sentence, notorious Washington power broker Joel Backman receives a surprise pardon. But Backman has serious enemies from his past. As the CIA watches him closely, the question is not whether he will be killed, but rather who will kill him first. Available in a tall Premium Edition. Reissue.",
                company = "Transworld Publishers Ltd",
                source = "../../Content/Books/TheBroker.png",
                price = 11.79,
                rate = 4.42,
                year = 2006,
                purhases = 1140,
                pages = 422,
                ISBN = 0345532007,
                tax = 190
            });
            db.Book.Add(new Books
            {
                name = "Mein Kampf",
                author = "Adolf Hitler",
                discription = "With 14 years left on a 20-year sentence, notorious Washington power broker Joel Backman receives a surprise pardon. But Backman has serious enemies from his past. As the CIA watches him closely, the question is not whether he will be killed, but rather who will kill him first. Available in a tall Premium Edition. Reissue.",
                company = "Transworld Publishers Ltd",
                source = "../../Content/Books/MainKampf.png",
                price = 17.79,
                rate = 4.23,
                year = 2006,
                purhases = 543,
                pages = 524,
                ISBN = 817224164,
                tax = 265
            });
            db.Book.Add(new Books
            {
                name = "Killing Kind",
                author = "Jane Casey",
                discription = "As a barrister, Ingrid Lewis is used to dealing with tricky clients, but no one has ever come close to John Webster. After Ingrid defended Webster against a stalking charge, he then turned on her – following her, ruining her relationship, even destroying her home.",
                company = "Amazon",
                source = "../../Content/Books/KillingKind.png",
                price = 17.79,
                rate = 3.80,
                year = 2022,
                purhases = 300,
                pages = 496,
                ISBN = 0008477922,
                tax = 260
            });

            db.Book.Add(new Books
            {
                name = "North Korea Deception",
                author = "Richard Lyntton",
                discription = "Richard Lyntton's North Korea Deception begins with its hero Jack Steele plunging into Russia's far eastern icy waters in a rescue attempt. The dangers and plot twists that follow arrive as fast and non-stop as a Socchi slalom run throughout this political action thriller. And the questions become how will Steele be able to save those around him as well as himself in the midst of the complicated web of Russian, UK, North Korean, US, and terrorist intrigues. Lyntton seasons the tale with romance, love, family, and even some mysterious spirituality. But the heart of the story is about trust and the challenge of doing right in the face of corruption. North Korea Deception is an engaging page turner that takes readers inside worlds it's safer to view from a comfy chair than the end of a gun barrel.",
                company = "Amazon",
                source = "../../Content/Books/NorthKoreaDECEPTION.png",
                price = 25.85,
                rate = 3.90,
                year = 2020,
                purhases = 400,
                pages = 364,
                ISBN = 1735490512,
                tax = 230
            });
            db.Book.Add(new Books
            {
                name = "Fire on Headless Mountain",
                author = "Iain Lawrence",
                discription = "Virgil is making his older siblings trek to a mountain lake on a trip unlike any they've taken before. They carry precious cargo: the ashes of their beloved mother, who asked that her remains be scattered at her favorite spot. Then a forest fire is sparked by a bolt of lightning at the exact moment when their van breaks down, and the journey quickly turns to disaster",
                company = "Amazon",
                source = "../../Content/Books/FireonHeadlessMountain.png",
                price = 9.99,
                rate = 3.0,
                year = 2023,
                purhases = 256,
                pages = 256,
                ISBN = 0823454630,
                tax = 101
            });
            db.Book.Add(new Books
            {
                name = "The Close",
                author = "Jane Casey",
                discription = "At first glance, Jellicoe Close seems to be a perfect suburban street – well-kept houses with pristine lawns, neighbours chatting over garden fences, children playing together. " +
                "But there are dark secrets behind the neat front doors, hidden dangers that include a ruthless criminal who will stop at nothing. It’s up to DS Maeve Kerrigan and DI Josh Derwent to uncover the truth.Posing " +
                "as a couple, they move into the Close,blurring the lines between professional and personal as never before. " +
                "And while Maeve and Josh try to gather the evidence they need, they have no idea of the danger they face – because someone in Jellicoe Close has murder on their mind.",
                company = "Amazon",
                source = "../../Content/Books/TheClose.png",
                price = 3.99,
                rate = 3.9,
                year = 2023,
                purhases = 230,
                pages = 410,
                ISBN = 0008404976,
                tax = 110
            });
            db.Book.Add(new Books
            {
                name = "Iron Flame",
                author = "REBECCA YARROS",
                discription = "",
                company = "Amazon",
                source = "../../Content/Books/IronFlame.png",
                price = 26.39,
                rate = 3.75,
                year = 2023,
                purhases = 100,
                pages = 512,
                ISBN = 9781649374172,
                tax = 212
            });
            db.Book.Add(new Books
            {
                name = "The Sleeper Lies",
                author = "Andrea Mara",
                discription = "I step forward, breathing fast. Movement. I force myself to take another step. I think about all of it, all of the deaths and all of the accidents and all of the pain. And I know what I need to do.",
                company = "Amazon",
                source = "../../Content/Books/TheSleeper.png",
                price = 13.99,
                rate = 3.99,
                year = 2023,
                purhases = 323,
                pages = 416,
                ISBN = 1781997667,
                tax = 111
            });
            db.Book.Add(new Books
            {
                name = "Holy Spirit: The Bondage Breaker",
                author = "David Diga Hernandez",
                discription = "I step forward, breathing fast. Movement. I force myself to take another step. I think about all of it, all of the deaths and all of the accidents and all of the pain. And I know what I need to do.",
                company = "Amazon",
                source = "../../Content/Books/HolySpiritBreaker.png",
                price = 19.79,
                rate = 3.80,
                year = 2023,
                purhases = 400,
                pages = 306,
                ISBN = 0768472407,
                tax = 143
            });
            db.Book.Add(new Books
            {
                name = "Destroying Fear",
                author = "John Ramirez & Juan Martinez",
                discription = "Fear is a form of torment the enemy tries to plague people with in order to paralyze them, to steal their purpose and destiny from God's best. None of us is immune to these attacks. Jesus came to destroy fear and set the captives free.",
                company = "Amazon",
                source = "../../Content/Books/DestroyingFear.png",
                price = 15.99,
                rate = 3.87,
                year = 2019,
                purhases = 370,
                pages = 224,
                ISBN = 080079947,
                tax = 145
            });
            db.Book.Add(new Books
            {
                name = "FIRE PRAYERS",
                author = "John Ramirez",
                discription = "This book will show you the importance of fighting the enemy in the spirit, and why being equipped with God’s warfare weapons is one of the most life-changing experiences of all.",
                company = "Amazon",
                source = "../../Content/Books/FirePlayers.png",
                price = 19.66,
                rate = 3.80,
                year = 2019,
                purhases = 487,
                pages = 224,
                ISBN = 163641155,
                tax = 149
            });
            db.Book.Add(new Books
            {
                name = "The War in Heaven",
                author = "Ivor Myers",
                discription = "A long time ago... there was war in heaven.Michael and his angels fought against the dragon; and the dragon fought and his angels, and prevailed not; neither was their place found any more in haven.And the great dragon was cast out, that old serpent, called the Devil, and Satan, which deceiveth the whole world: he was cast out into the earth, and his angels were cast out with him",
                company = "Amazon",
                source = "../../Content/Books/WarinHeaven.png",
                price = 5.95,
                rate = 3.30,
                year = 2020,
                purhases = 206,
                pages = 64,
                ISBN = 9781933291451,
                tax = 193
            });
            db.Book.Add(new Books
            {
                name = "Overcoming Evil",
                author = "Rick Joyner",
                discription = "Prophetic leader and author Rick Joyner exposes the three most powerful evil strongholds that together bind and control fallen mankind―racism, witchcraft, and the religious spirit. Discover the roots behind each of these strongholds, including the internal enemies of fear, pride, jealousy, guilt, and more.",
                company = "Amazon",
                source = "../../Content/Books/OverComingEvil.png",
                price = 17.03,
                rate = 4.00,
                year = 2022,
                purhases = 570,
                pages = 176,
                ISBN = 0768463424,
                tax = 200
            });
            db.Book.Add(new Books
            {
                name = "Courts of Heaven",
                author = "Robert Henderson",
                discription = "God is passionate about you fulfilling your purpose! In fact, there are books in Heaven that record your destiny and purpose. Their pages describe the very reason you were placed on the Earth.",
                company = "Amazon",
                source = "../../Content/Books/CourseofHeaven.png",
                price = 99.99,
                rate = 4.00,
                year = 2021,
                purhases = 1000,
                pages = 1032,
                ISBN = 0768413818,
                tax = 221
            });
            base.Seed(db);
        }
    }
}