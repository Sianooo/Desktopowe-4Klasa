#include <iostream>

using namespace std;

struct uczen {
    string imie;
    int wzrost;
    uczen* nastepnyElement;
    uczen* poprzedniElement;
};

int main() {
    uczen* glowa = NULL;
    uczen* nowy = NULL;
    char decyzja;

    do {
        nowy = new uczen; // alokacja

        cout << "Podaj imie: ";
        cin >> nowy->imie;
        cout << "Podaj wzrost w cm: ";
        cin >> nowy->wzrost;

        nowy->nastepnyElement = NULL;
        nowy->poprzedniElement = NULL;

        if (glowa == NULL) {
            glowa = nowy;
        } else {
            uczen* temp = glowa;
            while (temp->nastepnyElement != NULL) { // wskazuje na koniec listy
                temp = temp->nastepnyElement;
            }
            temp->nastepnyElement = nowy;
            nowy->poprzedniElement = temp;
        }

        cout << "Czy chcesz dodac nastepny element do listy? (t/n): ";
        cin >> decyzja;
    } while (decyzja == 't' || decyzja == 'n');

    uczen* temp = glowa;
    while (temp != NULL) {
        cout << temp->imie << endl;
        cout << temp->wzrost << endl;
        temp = temp->nastepnyElement;
    }

    // Zwolnienie pamiêci
    /*temp = glowa;
    while (temp != NULL) {
        uczen* doUsuniecia = temp;
        temp = temp->nastepnyElement;
        delete doUsuniecia;
    }*/

    return 0;
}
