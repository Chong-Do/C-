#include <iostream>
using namespace std;

int main() {
    int hp[5] = {100, 0, 60, 0, 50};
    int count = 0;

    for (int i = 0; i < 5; i++) {
        if (hp[i] > 0) {
            count++;
        }
    }

    cout << "So quai con song: " << count;

    return 0;
}
