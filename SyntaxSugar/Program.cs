//*Exercise 1*\\
//int answer = 4;
//string response;
//if (answer = 9)
//{
//    response = answer + " is less than nine";
//}
//else
//{
//    response = answer + “greater than or equal to nine”;
//};

//Syntax Suagr

int answer = 4;

var response = (answer < 9) 
            ? $"{answer} is less than nine" 
            : $"{answer} is greater than or equals to nine";

Console.WriteLine(response);
