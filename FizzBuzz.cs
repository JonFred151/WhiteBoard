//public method that accept divisible by 3, 5, or both 

public fizzbuzz(int x)
{
    string respond;
if (x % 3 == 0 )
{
     respond = "fizz"; 

}
else if (x % 5 == 0)
{
     respond = "buzz";
}
else if (x % 3 == 0 || x % 5 == 0 )
{
     respond = "fizzbuzz"; 
}
else
{
    respond = "There is no number that can divide by 3 or 5."
}   

return respond;
}
