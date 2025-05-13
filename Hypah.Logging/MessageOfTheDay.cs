
namespace Hypah.Logging
{
    internal static class MessageOfTheDay
    {
        private static string[] messages = new string[] {
            "Never let inspiration get in the way of your mistakes",
            "Sometimes, you gotta pretend everything is okay",
            "If brute force doesn't solve your problems, then you aren't using enough.",
            "SUPERCOMPUTER: what it sounded like before you bought it.",
            "I'm not anti-social; I'm just not user friendly",
            "Software never has bugs. It just develops random features.",
            "Evolution is God's way of issuing upgrades.",
            "I never forget a face, but in your case I’d be glad to make an exception.",

            "Start every day off with a smile and get it over with.", // inspirobot.me
            "Fasten your seatbelts. It's going to be a bumpy ride",// inspirobot.me
            "TEAMWORK: A few harmless flakes working together can unleash an avalanche of destruction.",// inspirobot.me
            "Accept that you're just a product, not a gift.",// inspirobot.me
            "Constipation. Just say NO",// inspirobot.me
            "Try to be the reason a strangr gets diarroea today.",// inspirobot.me
            "Dont' stop goofing around. Please.",// inspirobot.me
            "No destruction, no joy.",// inspirobot.me
            "If you get upset about the new world order, prepare to ignore perception.",// inspirobot.me
            "Rule #2: never let memories get in the way of a kick in the groin",// inspirobot.me
            "Solitude is a side effect",// inspirobot.me
            "Chase what is convenient, not wat is complicated",// inspirobot.me
            "search for inner pease, and you might achieve meaning",// inspirobot.me
            "You don't need to have a stairway to heaven in order to get addicted to heroin",// inspirobot.me
            "With real-life mistakes comes lear-life living",// inspirobot.me
            "You gotta show respect for a flame",// inspirobot.me
            "Sell cake. Get a job",// inspirobot.me
            "Sell your soul. It's never too late.",// inspirobot.me
            "You did not wake up today to get fucked by tentacles",// inspirobot.me
            "Someone has to be an assassin. It may as well be you.",// inspirobot.me
            "People who run away from the mentally ill enslave shrimps",// inspirobot.me
            "The only distinction between poison and a gonad, is that a gonad is free.",// inspirobot.me
            "With intelligent hatred comes intelligent discovery",// inspirobot.me
            "Before the moment you give up, comes pain.",// inspirobot.me
            "An office job is exactly like a recurring nightmare",// inspirobot.me
            "Wankers of earth, unite for the common good.",// inspirobot.me
            "Stop being ok",// inspirobot.me
            "Find money lying around and suppress evidence",// inspirobot.me
            "There is no point in not being open-minded. Just so you know",// inspirobot.me
            "You can be devine",// inspirobot.me
            "Drink yourself happy",// inspirobot.me
            "Humanity can be like an incredible bungee jump going nowhere",// inspirobot.me
            "Without intellect there can be no duties",// inspirobot.me
            "There are good viruses and there are vomit-inducting viruses.",// inspirobot.me
            "Spend money on your pain",// inspirobot.me
            "Exploring your own body can be a shitty voyage where there are no winners. Only losers",// inspirobot.me
            "You have always been a monkey",// inspirobot.me
            "A headache is a laughter just for you",// inspirobot.me
            "Alcohol inspires us to communicate with someone that cannot really be communicated with",// inspirobot.me
            "If there's a way to anticipate it, there's a way to admit it.",// inspirobot.me
            "They are rage, brutal, without mercy. But you. You will be worse. Rip and tear, until it is done.",// inspirobot.me

            "Unlike everything else in your life, your work here matters.", // DOOM 2016
            "You should not have allowed his location to be discovered. You have failed us.", // DOOM 2016
            "Weaponizing deamons. For a brighter Tomorrow! -UAC", // DOOM 2016
            
            "Never underestimate the power of stupid things in large numbers.", // Serious sam
            "To be or not to be, now that is a serious question.", // Serious sam
            "It's all fun and games until somebody loses an eye.", // Serious sam

            "Killing is wrong. And bad. There should be a new, stronger word for killing. Like badwrong, or badong. Yes, killing is badong. From this moment, I will stand for the opposite of killing: gnodab.", // kung pow"
            "Chicken go cluck-cluck, cow go moo. Piggie go oink-oink, how 'bout you?", // kung pow
            "If you've got an ass I'll kick it!", // kung pow
            "That's a lot of nuts! That'll be four bucks, baby! You want fries with that?", // kung pow
            "What do you get when you cross an owl with a bungie cord? MY ASS!", // kung pow

            "I CAN'T BREATHE IN THIS THING!", // spaceballs
            "I'm surrounded by assholes!", // spaceballs
            "You're delicious Pizza!", // spaceballs

        };

        internal static string GetMessage()
        {
            Random r = new();
            return messages[r.Next(messages.Length)];
        }
    }

}
