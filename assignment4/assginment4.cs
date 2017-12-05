using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class File{
    public string name;
    public string partition;
    public int dayOfCreation;
    public int monthOfCreation;
    public int yearOfCreation;
    
    public File(string n, string p, int d, int m, int y){
        name = n;
        partition = p;
        dayOfCreation = d;
        monthOfCreation = m;
        yearOfCreation = y;
    }
    public void printData(){
        Console.WriteLine("A new file called {0} in partition {1} is created in {2}/{3}/{4}", name, partition, dayOfCreation, monthOfCreation, yearOfCreation);
    }
}

class image : File{
    string type;
    public image(string n, string p, int d, int m, int y, string ty) : base(n, p, d, m, y){
        type = ty;
        Console.WriteLine("Hello, I have created a new image, I hope you'll love it!!");
    }
     public void printData(){
        Console.WriteLine("A new file called {0} in partition {1} is created in {2}/{3}/{4} and it is of type {5}", name, partition, dayOfCreation, monthOfCreation, yearOfCreation, type);
    }
}

class video : File{
    string type;
    public video(string n, string p, int d, int m, int y, string ty) : base(n, p, d, m, y){
        type = ty;
        Console.WriteLine("Hello, I have created a new video, I hope you'll love it!!");
    }
     public void printData(){
        Console.WriteLine("A new file called {0} in partition {1} is created in {2}/{3}/{4} and it is of type {5}", name, partition, dayOfCreation, monthOfCreation, yearOfCreation, type);
    }
}


class audio : File{
    string type;
    public audio(string n, string p, int d, int m, int y, string ty) : base(n, p, d, m, y){
        type = ty;
        Console.WriteLine("Hello, I have created a new audio, I hope you'll love it!!");
    }
     public void printData(){
        Console.WriteLine("A new file called {0} in partition {1} is created in {2}/{3}/{4} and it is of type {5}", name, partition, dayOfCreation, monthOfCreation, yearOfCreation, type);
    }
}


class text : File{
    string type;
    public text(string n, string p, int d, int m, int y, string ty) : base(n, p, d, m, y){
        type = ty;
         Console.WriteLine("Hello, I have created a new text, I hope you'll love it!!");

    }
     public void printData(){
        Console.WriteLine("A new file called {0} in partition {1} is created in {2}/{3}/{4} and it is of type {5}", name, partition, dayOfCreation, monthOfCreation, yearOfCreation, type);
    }
}


class Program
{
    static void Main()
    {
       image newimage = new image("newImage", "E", 1, 4, 2017, "image");
       newimage.printData();
       
       text newtext = new text("newtext", "E", 1, 4, 2017, "text");
       newtext.printData();
    }
}
