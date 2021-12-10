// 72. Написать программу возведения числа А в целую стень B

int power(int A, int B)
{
    return B == 0 ? 1 : power(A, B - 1) * A;
}

//оптимизировать используя свойство 2^28 = ((2^2)^2)^7


// int power2(int A, int B)
// {
//     if (B==0) {return 1;}
//     else ()

//     return B == 0 ? 1 : power(A, B - 1) * A;
// }