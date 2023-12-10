// c# 12 we can set default value in this example age=30
var lambda = (int age = 30) => $"Nick is {age} years old";

lambda(50);