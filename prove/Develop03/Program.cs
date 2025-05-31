using System;

class Program
{
    static void Main(string[] args)
    {
        Reference Ref1 = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(Ref1, "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them");      
    }
}