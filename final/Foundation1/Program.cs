using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        Video video1 = new Video();
        video1._autor = "Natalia";
        video1._title = "How to Make the Best Homemade Pizza";
        video1._lengthSec = 500;

        video1._comments.Add(new Comment() {_name = "Juan", _commentText = "I like your videos"});
        video1._comments.Add(new Comment() {_name = "Beatriz", _commentText = "Great video! I learned so much"});
        video1._comments.Add(new Comment() {_name = "Ignacio", _commentText = "This is amazing, Thank you for sharing"});
        video1._comments.Add(new Comment() {_name = "Marisol", _commentText = "This video made my day, So inspiring"});
        video1.DisplayVideo();


        Video video2 = new Video();
        video2._autor = "Daniel";
        video2._title = "Art History in 10 Minutes";
        video2._lengthSec = 500;

        video2._comments.Add(new Comment() {_name = "Paola", _commentText = "I can't believe I didn't know this before. Thank you!"});
        video2._comments.Add(new Comment() {_name = "Ernesto", _commentText = "Your energy is infectious. Love watching your videos."});
        video2._comments.Add(new Comment() {_name = "Fernando", _commentText = "Your videos always put a smile on my face."});
        //video2._comments.Add(new Comment() {_name = "Jorge", _commentText = "I've been struggling with this, but your video gave me hope."});
        video2.DisplayVideo();
        

        Video video3 = new Video();
        video3._autor = "Verónica";
        video3._title = "Programming Your Mind for Success";
        video3._lengthSec = 500;

        video3._comments.Add(new Comment() {_name = "Carolina", _commentText = "You make it so easy to understand. Thank you for breaking it down."});
        video3._comments.Add(new Comment() {_name = "Ana", _commentText = "This is exactly what I needed to hear. Thank you."});
        video3._comments.Add(new Comment() {_name = "Ignacio", _commentText = "Love your channel! Keep up the great work."});
        video3._comments.Add(new Comment() {_name = "Rafael", _commentText = "So informative and well-done. Thank you for sharing your knowledge."});
        video3.DisplayVideo();


        Video video4 = new Video();
        video4._autor = "Gabriel";
        video4._title = "10 Easy Vegetarian Recipes for Beginners";
        video4._lengthSec = 500;

        video4._comments.Add(new Comment() {_name = "Francisco", _commentText = "This video is a game-changer, Thank you for making it"});
        video4._comments.Add(new Comment() {_name = "Mario", _commentText = "Your enthusiasm is contagious, Keep doing what you're doing"});
        video4._comments.Add(new Comment() {_name = "Lucía", _commentText = "This video was so helpful, Can't wait to try out what I learned"});
        //video4._comments.Add(new Comment() {_name = "Teresa", _commentText = "You have such a gift for explaining complex ideas in a simple way"});
        video4.DisplayVideo();

    }
}