def filling(person):
    with open('file_catalog/catalog.txt', 'a', encoding='utf-8') as file_catalog:
        for el in person:
            file_catalog.write(el + '\n')
        file_catalog.write('\n')