using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

public class Entry{

    public string _prompt;

    public List<string> _gratitudePrompts = ["What am I thankful for today?",
    "What do I love most about my body, and why?",
    "Who has loved you unconditionally?",
    "What was the best gift you received as a child? ",
    "What gift have you given that has made a difference in someone’s life?",
    "What adversity are you grateful for? ",
    "What are your favorite things in the natural world? ",
    "What do you deeply enjoy doing alone? ",
    "Write about something you think is adorable.",
    "What freedoms are you grateful for? ",
    "Did a stranger do a favor for you today?",
    "List 10 frivolous things that bring you joy.",
    "Write about a random act of kindness."
    ];

    public List<string> _personalPrompts = ["What’s your passion, and how did you discover it?",
    "If you knew you wouldn’t fail, what would you do?",
    "What have you learned that has changed your values?",
    "When people complain about you, what do they say? ",
    "If you had $150,000 to spend in 24 hours or less, how would you spend it?",
    "What is your favorite way to start the day?",
    "Where does your future self live? What does that look like? ",
    "List 10 of your favorite things.",
    "What do you value most?",
    "What skill do you need to learn to advance to the next level?",
    "When did you last boldly take action?",
    "What’s the hardest thing you’ve ever done?",
    ];

    public List<string> _historyPrompts = ["",
    "What was your favorite toy?",
    "Write about your name. What does it mean? Who chose it?",
    "What was your favorite toy?",
    "What kinds of wildlife did you encounter as a kid?",
    "What did a typical mealtime look like when you were growing up?",
    "Who was your childhood best friend?",
    "Did your family survive a tragedy? What happened?",
    "What was the hardest part about growing up?",
    "What pets do you have? ",
    "What did you enjoy doing most with friends and family? ",
    "What were you worried about as a kid that turned out to be not a big deal for you as a grown up?"
    ];

    public List<string> _reflectionPrompts = ["",
    "Reflect on a mistake you made and what you learned from the experience.",
    "Write about a time when you faced a difficult decision and how you ultimately made your choice.",
    "Think about a relationship that has changed over time and reflect on how it has evolved.",
    "Write about a challenge you faced and how you overcame it.",
    "Reflect on a time when you felt proud of yourself and what you accomplished.",
    "Reflect on a time when you felt truly heard and seen by someone else.",
    "Reflect on a time when you were able to forgive someone who hurt you.",
    "Write about a difficult conversation you had and how it made you feel.",
    "What was the highlight of your day and why?",
    "What is something you learned today about yourself or the world around you?",
    "What were your biggest successes this week, and what did you learn from them?",
    "What were your goals for this month, and how did you progress toward them?",
    "What were some things that made you feel happy or fulfilled this month, and why?"
    ];

    
    public List<string> entries = new List<string>();

    public string _response;

    public string _date;
    public string DisplayFullEntry(){
        // call prompt from prompter and set a variable as a list-- saves each entry as a list and then loops through and prints each 
        return $"{_date}:   {_prompt}:   {_response}";
    }

    public void GratitudePromptGenerator() {
        var random = new Random();
        int index = random.Next(_gratitudePrompts.Count);
        _prompt = _gratitudePrompts[index];
        Console.Write($"{_prompt} \n >");

    }
    public void PersonalPromptGenerator() {
        var random = new Random();
        int index = random.Next(_personalPrompts.Count);
        _prompt = _personalPrompts[index];
        Console.Write($"{_prompt} \n >");

    }

    public void HistoryPromptGenerator() {
        var random = new Random();
        int index = random.Next(_historyPrompts.Count);
        _prompt = _historyPrompts[index];
        Console.Write($"{_prompt} \n >");

    }

    public void ReflectionPromptGenerator() {
        var random = new Random();
        int index = random.Next(_reflectionPrompts.Count);
        _prompt = _reflectionPrompts[index];
        Console.Write($"{_prompt} \n >");

    }

}
