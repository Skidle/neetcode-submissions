from typing import List

def read_integers() -> List[int]:
    numbers = input().split(",")
    result = []
    for num in numbers:
        result.append(int(num))
    return result

# do not modify the code below
print(read_integers())
print(read_integers())
print(read_integers())
