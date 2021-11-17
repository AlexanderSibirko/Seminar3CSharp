// Каждая буква замещает некоторую десятичную цифру 0 - 9. Расшифруйте равенство и найдите наибольшую СКОРОСТЬ.
// - СК*ОР=ОСТЬ
// - СКО-РО=СТЬ
// - СКО+РО=СТЬ

//C, K, О, Р, Т, Ь - задействованы 6 цифр (из 10ти).
//Перебирать от 0 до 9 исключая уже использованные? Под каждую букву? ???Есть ли другой способ ???
//Перебирать в очередности в слове скорость и в обратном порядке от 9 до 0, так мы получим наибольшее значение СКОРОСТЬ (перебирая наивысший разряд с наибольшего значения)


int speedSolve1()
{
    int C; int K; int O; int P; int T; int b;
    for (C = 9; C >= 0; C--)
    {
        for (K = 9; K >= 0; K--)
        {
            if (K == C) { continue; }
            for (O = 9; O >= 0; O--)
            {
                if (O == K || O == C) { continue; }
                for (P = 9; P >= 0; P--)
                {
                    if (P == C || P == K || P == O) { continue; }
                    for (T = 9; T >= 0; T--)
                    {
                        if (T == C || T == K || T == O || T == P) { continue; }
                        for (b = 9; b >= 0; b--)
                        {
                            //Console.WriteLine(((10*C+K)*(10*O+P)) + "==" + (1000*O+100*C+10*T+b) + $" {C} {K} {O} {P} {O} {C} {T} {b}");
                            if (b == C || b==K || b == O || b == P || b == T ){continue;}
                            if (((10*C+K)*(10*O+P)) == (1000*O+100*C+10*T+b)) {return 10000000*C+1000000*K+100000*O+10000*P+1000*O+100*C+10*T+b;} // - СК*ОР=ОСТЬ
                        }
                    }
                }
            }
        }
    }
    return -1;
}

int speedSolve2()
{
    int C; int K; int O; int P; int T; int b;
    for (C = 9; C >= 0; C--)
    {
        for (K = 9; K >= 0; K--)
        {
            if (K == C) { continue; }
            for (O = 9; O >= 0; O--)
            {
                if (O == K || O == C) { continue; }
                for (P = 9; P >= 0; P--)
                {
                    if (P == C || P == K || P == O) { continue; }
                    for (T = 9; T >= 0; T--)
                    {
                        if (T == C || T == K || T == O || T == P) { continue; }
                        for (b = 9; b >= 0; b--)
                        {
                            if (b == C || b==K || b == O || b == P || b == T ){continue;}
                            if (((100*C+10*K+O)-(10*P+O)) == (100*C+10*T+b)) {return 10000000*C+1000000*K+100000*O+10000*P+1000*O+100*C+10*T+b;} // - СКО-РО=СТЬ
                        }
                    }
                }
            }
        }
    }
    return -1;
}

int speedSolve3()
{
    int C; int K; int O; int P; int T; int b;
    for (C = 9; C >= 0; C--)
    {
        for (K = 9; K >= 0; K--)
        {
            if (K == C) { continue; }
            for (O = 9; O >= 0; O--)
            {
                if (O == K || O == C) { continue; }
                for (P = 9; P >= 0; P--)
                {
                    if (P == C || P == K || P == O) { continue; }
                    for (T = 9; T >= 0; T--)
                    {
                        if (T == C || T == K || T == O || T == P) { continue; }
                        for (b = 9; b >= 0; b--)
                        {
                            if (b == C || b==K || b == O || b == P || b == T ){continue;}
                            if (((100*C+10*K+O)+(10*P+O)) == (100*C+10*T+b)) {return 10000000*C+1000000*K+100000*O+10000*P+1000*O+100*C+10*T+b;} // - СКО+РО=СТЬ
                        }
                    }
                }
            }
        }
    }
    return -1;
}

Console.WriteLine(speedSolve1());
Console.WriteLine(speedSolve2());
Console.WriteLine(speedSolve3());