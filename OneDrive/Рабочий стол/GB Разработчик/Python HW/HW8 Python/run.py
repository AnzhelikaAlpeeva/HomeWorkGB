from user import choose_mode
from fill_catalog import filling
from read_catalog import search_person

def running():
    person, mode = choose_mode()
    if mode == 'запись':
        filling(person)
    else:
        search_person(person)
