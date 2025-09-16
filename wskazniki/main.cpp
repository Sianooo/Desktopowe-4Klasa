#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;

int main()
{
    int a;
    a = 8;
    int *w;
    w = &a;
    cout << a << endl;
    cout << w << endl; // adres
    cout << *w << endl; // wskaznik z a

    *w = 15;
    cout << a << endl;
    cout << endl;
    cout << endl;

    int *w1, *w2, d, b, s;

    d = 14;
    b = 20;

    w1 = &d; // umieszczanie pod wskaznikiem (pod adresem)
    w2 = &b;

    cout << *w1 << endl;
    cout << *w2 << endl;

    s = *w1 + *w2;

    cout << s << endl;
    cout << endl;

    int tab[10];
    srand(time(NULL));
    for (int i = 0; i < 10; i++) {
        tab[i] = rand() % 90 + 10;
        cout << tab[i] << endl;
    }

    cout << endl;

    int *number;
    number = &tab[0];

    for (int i = 0; i < 10; i++) {
        *number = rand() % 900 + 100;
        number++;
        cout << tab[i] << endl;
    }

    /*int *w;
    w = new int[20]; // alokacja pamieci

    for (int i = 0; i < 20; i++) {
        w[i] = rand() % 10;
        cout << w[i] << " ";
    }
    cout << endl;

    delete[] w;

    cout << "Po delete[] (niebezpieczne):" << endl;
    for (int i = 0; i < 20; i++) {
        cout << w[i] << " ";
    }
    */
    cout << endl;

    int **wskaznik; // podwojny wskaznik
    wskaznik = new int*[6];

    for (int i = 0; i < 6; i++) {
        wskaznik[i] = new int[3];
        cout << wskaznik[i] << " " << endl;
    }

    for (int i = 0; i < 6; i++) {
        for (int j = 0; j < 3; j++) {
            wskaznik[i][j] = rand() % 90 + 10;
            cout << wskaznik[i][j] << " ";
        }
        cout << endl;
    }

    // Szukanie najmniejszej liczby
    int minValue = wskaznik[0][0];
    for (int i = 0; i < 6; i++) {
        for (int j = 0; j < 3; j++) {
            if (wskaznik[i][j] < minValue) {
                minValue = wskaznik[i][j];
            }
        }
    }

    cout << "Najmniejsza liczba w tablicy: " << minValue << endl;

    // Zwolnienie pamiêci dla podwójnego wskaŸnika
    for (int i = 0; i < 6; i++) {
        delete[] wskaznik[i];
    }
    delete[] wskaznik;

    return 0;
}
