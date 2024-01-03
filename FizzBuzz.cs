//public method that accept divisble by 3, 5 , or both 

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
return respond;
}