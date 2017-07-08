using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* In music, certain frequencies correspond to certain musical notes (example: A -> 440hz, C# -> 554.37hz). 
You will be given frequencies as real numbers on the first line of the input (space-separated). Your task is to convert the numbers to 
their musical note representation, then separate them into naturals (C, B, F and etc.) and sharp notes (C#, F#, A#, etc.). After that, 
print both lists in the console in the format described in the examples. After you print them, sum each list’s frequencies and print it 
on the console, rounded to the second decimal place. */

namespace NoteStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFrequencies = Console.ReadLine()
                .Split().Select(double.Parse).
                ToArray();
            var notes = "C C# D D# E F F# G G# A A# B".Split(' ').ToList();
            var frequencies = "261.63 277.18 293.66 311.13 329.63 349.23 369.99 392.00 415.30 440.00 466.16 493.88"
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var finalNotes = new List<string>();

            var sharps = new List<string>();
            var naturals = new List<string>();

            foreach (var item in inputFrequencies)
            {
                var frequencyIndex = frequencies.IndexOf(item);
                var note = notes[frequencyIndex];
                finalNotes.Add(note);
                
            }
            Console.WriteLine("Notes: {0}", string.Join(" ",finalNotes));


            foreach (var note in finalNotes)
            {
                if (note.Contains("#"))
                {
                    sharps.Add(note);
                }
                else
                {
                    naturals.Add(note);
                }
            }
            Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));

            var naturalSum = 0d;

            foreach (var note in naturals)
            {
                var frequencyIndex = notes.IndexOf(note);
                var frequency = frequencies[frequencyIndex];
                naturalSum += frequency;
            }

            var sharpSum = 0d;

            foreach (var note in sharps)
            {
                var frequencyIndex = notes.IndexOf(note);
                var frequency = frequencies[frequencyIndex];
                sharpSum += frequency;
            }
            Console.WriteLine("Naturals sum: {0}",naturalSum);
            Console.WriteLine("Sharps sum: {0}", sharpSum);
        }
        }
    }

