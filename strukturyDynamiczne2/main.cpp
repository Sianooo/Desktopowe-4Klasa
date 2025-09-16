#include <iostream>

using namespace std;

struct przedmiot{
    string nazwaPrzedmiotu;
    float cena;
    przedmiot *nastepny;
};

przedmiot* usuwanieElementuZListy(przedmiot *glowa,string usuwanyElement){//funkcja zwraca wskaznik
    przedmiot *temp;
    przedmiot *poprzedniElement;
    temp=glowa;

    if(temp->nazwaPrzedmiotu==usuwanyElement){
        if(glowa==glowa){
            glowa=glowa->nastepny;
            delete temp;
            temp=glowa->nastepny;
        }else{
            poprzedniElement->nastepny=temp->nastepny;
            delete temp;

        }
    }
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

    return 0;
}
