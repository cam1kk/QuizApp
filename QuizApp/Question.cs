using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Question
{
    public string Text { get; set; }
    public List<string> Answers { get; set; }
    public int CorrectAnswerIndex { get; set; }

    public Question(string text,List<string> answers, int correctanswerindex)
    {
        Text = text;
        Answers = answers;
        CorrectAnswerIndex = correctanswerindex;
    }
    public void Show()
    {
        Console.WriteLine(Text);
        for (int i = 0; i < Answers.Count(); i++)
        {
            Console.WriteLine($"{i + 1}) {Answers[i]}");
        }
        Console.WriteLine(CorrectAnswerIndex);
    }
    public void ShowAnswers()
    {
        for (int i = 0; i < Answers.Count(); i++)
        {
            Console.WriteLine($"{i + 1}) {Answers[i]}");
        }
    }
    public void Change()
    {
        Console.WriteLine("1.Change question text\n2.Change answers\n3. Change correct answer\n");
        int choice = int.Parse(Console.ReadLine());
        while (true)
        {
            if (choice == 1)
            {
                Console.Clear();
                Console.WriteLine("Enter new question text");
                Text = Console.ReadLine();
                break;
            }
            else if (choice == 2)
            {
                Console.Clear();
                Console.WriteLine("Enter new answers");
                for (int i = 0; i < Answers.Count();i++)
                {
                    Console.WriteLine($"Answer {i+1}: {Answers[i]}");
                    Console.WriteLine("Do you want to change this answer?\n1 - Yes\n2 - No");
                    int choice2 = int.Parse(Console.ReadLine());
                    if (choice2 == 1)
                    {
                        Console.WriteLine("Enter new answer: ");
                        Answers[i] = Console.ReadLine();
                    }
                    else if (choice2 == 2)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You entered an incorrect number");
                        Thread.Sleep(700);i--;continue;
                    }
                }
            }
            else if (choice == 3)
            {
                Console.Clear();
                for (int j = 0; int j < length; int i++)
                {
                    
                }
            }
        }
    }
}