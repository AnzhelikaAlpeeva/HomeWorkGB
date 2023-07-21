def search_person(person):
    with open('file_catalog/catalog.txt', 'r', encoding='utf-8') as file_catalog:
        for char in file_catalog:
                print(char.rstrip())