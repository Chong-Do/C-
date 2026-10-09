#include <iostream>
#include <string>
using namespace std;

class Player {
public:
    string name;
    int hp;

    void showInfo() {
        cout << "Ten: " << name << endl;
        cout << "Mau: " << hp << endl;
    }
};

int main() {
    Player player1;
    player1.name = "Knight";
    player1.hp = 100;

    Player player2;
    player2.name = "Mage";
    player2.hp = 70;

    player1.showInfo();
    cout << endl;
    player2.showInfo();

    return 0;
}
