#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;

void wypelnijTablice(int iloscWierszy,int** tab){
    srand(time(NULL));
    for(int i=0;i<iloscWierszy;i++){
        for(int j=0;j<6;j++){
        tab[i][j]=rand()%49+1;
        }
    }
}

void wypisz(int iloscWierszy,int** tab){
     for(int i=0;i<iloscWierszy;i++){
        cout<<"Losowanie "<<i+1<<" : ";
        for(int j=0;j<6;j++){
            cout<<tab[i][j]<<" ";
        }
        cout<<endl;
    }
}

int main()
{
    int iloscZestaw=0;
    cout<<"Podaj ilosc zestawow"<<endl;
    cin>>iloscZestaw;

    int** tab=new int* [iloscZestaw];
    for( int i=0;i<iloscZestaw;i++){
        tab[i]= new int[6];
    }
    wypelnijTablice(iloscZestaw,tab);
    cout<<"Zestawy wylosowanych liczb"<<endl;
    wypisz(iloscZestaw,tab);

    int liczba=0;
    for(int i=1;i<50;i++){
        for(int j=0;j<iloscZestaw;j++){
            for(int k=0;k<6;i++){
                if(tab[k][k]==i){
                    liczba++;
                }
            }
        }
        cout<<"Wystapienie liczby "<<i<<" : "<<endl;
    }
    return 0;
}
