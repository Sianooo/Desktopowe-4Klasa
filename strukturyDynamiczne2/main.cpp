#include <iostream>

using namespace std;

struct przedmiot{
    string nazwaPrzedmiotu;
    float cena;
    przedmiot *nastepny;
};

przedmiot* usuwanieElementuZListy(przedmiot *glowa, string usuwanyElement) {
    przedmiot *temp = glowa;
    przedmiot *poprzedni = NULL;

    // Przeszukiwanie listy
    while (temp != NULL && temp->nazwaPrzedmiotu != usuwanyElement) {
        poprzedni = temp;
        temp = temp->nastepny;
    }

    // Jeœli element nie zosta³ znaleziony
    if (temp == NULL) {
        return glowa;
    }

    // Jeœli usuwamy pierwszy element
    if (poprzedni == NULL) {
        glowa = temp->nastepny;
    } else {
        // Usuwanie elementu z œrodka lub koñca
        poprzedni->nastepny = temp->nastepny;
    }

    delete temp; // Zwolnienie pamiêci
    return glowa;
}

int main()
{
    przedmiot *glowa=NULL;//identyfikator listy
    przedmiot *ogon=NULL;
    przedmiot *nowyElement;
    char decyzja;

    do{
    nowyElement= new przedmiot;//alokacja pamieci

    cout<<"Podaj nazwe przedmiotu oraz cene :"<<endl;
    cin>>nowyElement->nazwaPrzedmiotu;//wprowadzenie do listy
    cin>>nowyElement->cena;
    nowyElement->nastepny=NULL;

    if(glowa==NULL){
        glowa=nowyElement;
        ogon=nowyElement;
    }else{
       ogon->nastepny=nowyElement;
       ogon=nowyElement;
    }

    cout<<"Czy chesz wprowadzic nowy element do listy ? t/n"<<endl;
    cin>>decyzja;
    }while(decyzja=='t'||decyzja=='T');

    cout<<"Lista przedmiotow: "<<endl;

    //wypisywanie:->
    przedmiot *temp;
    temp=glowa;
    while(temp!=NULL){
        cout<<temp->nazwaPrzedmiotu<<endl;
        cout<<temp->cena<<endl;
        temp=temp->nastepny;
    }


    // Usuwanie elementu
    string usuwanyElement;
    cout << "Podaj nazwe przedmiotu do usuniecia: ";
    cin >> usuwanyElement;
    glowa = usuwanieElementuZListy(glowa, usuwanyElement);

    // Wypisywanie listy po usuniêciu
    cout << "Lista po usunieciu:" << endl;
    temp = glowa;
    while (temp != NULL) {
        cout << temp->nazwaPrzedmiotu << " " << temp->cena << endl;
        temp = temp->nastepny;
    }
    return 0;
}
