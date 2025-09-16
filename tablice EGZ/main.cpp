#include <iostream>
using namespace std;

class tablica {
    int tab[10];

public:
    void wypelnienie() {
        for (int i = 0; i < 10; i++) {
            cin >> tab[i];
        }
    }

    void wypisywanie() {
        for (int i = 0; i < 10; i++) {
            cout << tab[i] << " ";
        }
        cout << endl;
    }

private:
    int szukajacaMax() {
        int max = tab[0];
        for (int i = 1; i < 10; i++) {
            if (tab[i] > max) {
                max = tab[i];
            }
        }
        return max;
    }
};

int main() {
    tablica tab;
    cout << "Podaj elementy tablicy" << endl;
    tab.wypelnienie();
    cout << "Otrzymana tablica:" << endl;
    tab.wypisywanie();

    return 0;
}
