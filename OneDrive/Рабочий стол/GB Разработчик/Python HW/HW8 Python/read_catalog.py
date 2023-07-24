# # дополнение после разбора на семинаре
# def search_person(surname):
#     with open('file_catalog/catalog.txt', 'r', encoding='utf-8') as file_catalog:
#         while True:
#             line = file_catalog.readline()
#             if not line:
#                 break
#             if line[:-1] == surname:
#                 print(line[:-1])
#                 print(file_catalog.readline())
#                 print(file_catalog.readline())
#                 print(file_catalog.readline())
#                 print()

# Начальное решение (выводился весь файл, так как я искала просто по файлу есть или нет ФИО или телефон, при вводе)
def search_person(person):
    with open('file_catalog/catalog.txt', 'r', encoding='utf-8') as file_catalog:
        for char in file_catalog:
                print(char.rstrip())