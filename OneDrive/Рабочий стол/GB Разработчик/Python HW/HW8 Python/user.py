def choose_mode():
    mode = input('Выберите режим работы со справочником: запись или поиск - ')
    if mode == 'запись':
        person = fill_person()
    elif mode == 'поиск':
        person = show_person()
    else:
        print('Такого режима не существует!')
        choose_mode()
    return person, mode


def fill_person():
    surname = input('Введите фамилию: ')
    name = input('Введите имя: ')
    patronym = input('Введите отчество: ')
    phone = input('Введите телефон: ')
    return surname, name, patronym, phone

# def show_person():
#     surname = input('Введите фамилию человека, которого ищите: ')
#     return surname

def show_person():
    char = input('Введите фамилию/имя/отчество/телефон человека, которого ищите: ')
    data = open('file_catalog/catalog.txt', 'r', encoding='utf-8')
    text = data.read()
    if char in text:
        print('Такой человек есть в справочнике')
    else:
        print('Человек не найден')
    print('\n')

