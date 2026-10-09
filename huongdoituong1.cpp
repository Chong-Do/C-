#include <iostream>
#include <string>
using namespace std;

class Player {
public:
    string name;
    int hp;

    void takeDamage(int damage) {
        hp = hp - damage;
    }
};

int main() {
    Player hero;

    hero.name = "Knight";
    hero.hp = 100;

    hero.takeDamage(30);

    cout << hero.name << endl;
    cout << hero.hp;

    return 0;
}
