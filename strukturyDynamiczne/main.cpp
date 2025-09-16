#include <iostream>

using namespace std;

struct Osoba{
    string nazwisko;
    int wiek;
    Osoba *next;

};

int main()
{
    Osoba *head=NULL;
    Osoba *nowy;
    char d;

    do{

    try{
        nowy= new Osoba;
    }
    catch(bad_alloc){
        cout<<"Nie ma miejsca na dany element";
        break;
    }

    cout<<"Podaj nazwisko"<<" "<<endl;
    cin>>nowy->nazwisko;
    cout<<"Podaj wiek"<<" "<<endl;
    cin>>nowy->wiek;
    nowy->next=head;
    head=nowy;

    cout<<"Czy chcesz dodac nowa osobe do listy ? t/n:"<<" "<<endl;
    cin>>d;
    }while(d=='t');

    Osoba *temp;
    temp=head;
    while(temp!=NULL){
        cout<<temp->nazwisko<<endl;
        cout<<temp->wiek<<endl;
        temp=temp->next;
    }



    return 0;
}
