#include <iostream>
#include <string>
using namespace std;

class Player {
public:
    string name;
    int hp;

    Player(string playerName, int playerHp) {
        name = playerName;
        hp = playerHp;
    }

    void heal(int amount) {
        hp = hp + amount;

        if (hp > 100) {
            hp = 100;
        }
    }

    void showInfo() {
        cout << "Ten: " << name << endl;
        cout << "Mau: " << hp << endl;
    }
};

int main() {
    Player hero("Knight", 60);

    hero.heal(20);
    hero.showInfo();

    return 0;
}
