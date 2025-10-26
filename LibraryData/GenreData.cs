using System;
using System.Collections.Generic;
using LibraryClasses;

namespace LibraryData
{
    public static class GenreData
    {
        public static List<Genre> GetGenres()
        {
            return new List<Genre>
            {
                new Genre("Fiction", "Literary works based on imaginative narration rather than factual events."),
                new Genre("Non-Fiction", "Informative or factual literature, including biographies, history, and essays."),
                new Genre("Mystery", "Stories focused on solving a crime, puzzle, or secret."),
                new Genre("Fantasy", "Fiction featuring magical elements, mythical creatures, or imaginary worlds."),
                new Genre("Science Fiction", "Speculative fiction often based on futuristic science or technology."),
                new Genre("Romance", "Stories centered around love, relationships, and emotional bonds."),
                new Genre("Horror", "Fiction designed to evoke fear, suspense, or dread."),
                new Genre("Historical Fiction", "Stories set in the past that blend real historical elements with fiction."),
                new Genre("Adventure", "Stories featuring action, exploration, and risk-taking journeys."),
                new Genre("Drama", "Serious, character-driven stories focusing on emotional and moral conflicts.")
            };
        }
    }
}
