# TODO list

> Versione 2.23.9.10 \
> <code>(2) Millennio, (23) Anno, (9) Mese, (10) Giorno</code>


> EvoSpan sarà coperto e vincola da una licenza proprietaria, per vietare il riutilizzo del codice sorgente.\
> Può essere studiato ma non replicato!

**EvoSpan** sarà il gestionale perfetto per tutti, sarà moderno, esteticamente molto bello e sopratutto portatile.\
Le principali caratteristiche di **EvoSpan** sono:
- Portabilità
- Tecnologico
- Professionale
- Adatto a tutti

### Lista dei siti di documentazione:
- Documentazione ufficiale di [Xamarin.Forms (.NET MAUI)](https://learn.microsoft.com/it-it/xamarin/xamarin-forms/user-interface/boxview)
- Documentazione di [SkiaSharp (per grafica 2d avanzata)](https://learn.microsoft.com/it-it/xamarin/xamarin-forms/user-interface/graphics/skiasharp/)
- [Translate extension using geolocalization](https://learn.microsoft.com/en-us/xamarin/community-toolkit/extensions/translateextension)
- Video YouTube [freeCodeCamping.org](https://www.youtube.com/watch?v=n3tA3Ku65_8)

# Portabilità

La caratteristica che considero più importante è la **portabilità**, poiché potrà essere installato su computer Windows 10/11, Linux e MacOS.\
In più sarà anche disponibile l'applicazione mobile da accopiare al proprio gestionale per averlo direttamente in tasca; compatibile con Android e IOS.\
Ogni volta che verrà aggiunta un'attività in agenda verrà inviato un messaggio/mail/notifica all'utente a cui è stata assegnata.

# Utenti attività

- [ ] Completato

> Alcune impostazioni dovranno essere revisionate.\
> Potrebbero essere aggiunte più impostazioni.\
> Da definire meglio

Quando si crea un nuovo utente (che corrisponde agli impiegati presenti in azienda) dovranno essere impostati le seguenti impstazioni:
- **Nome Utente**: un nome identificativo
- **Password**: servirà per accedere al gestionale sia dall'app mobile che da PC
- **E-mail**
- **Numero di telefono**
- **Nome e Cognome**
- **Data di nascita**
- **Ruolo**: mansione che svolge l'utente in questione
- **Retribuzione oraria**
- **Costo Servizio Oraria**
- **Calendario turni di lavoro**

## Ruoli (inside) Utenti

Quando viene creato un utente, gli può essere assegnato un _**ruolo**_:
- Admin
- Co-Admin
- Default

### Ruolo: Admin

Se il ruolo dell'utente è impostato su <code>admin</code>, allora l'utente avrà accesso a tutte le funzionalità del gestionale. \
Elenco delle funzionalità di aggiunta, elimina e modifica:
- Nuovi utenti e assegnamento del ruolo
- Utenti pre-esistenti
- Attività in agenda
- Clienti
- Prodotti
- Listini prezzi (sconti, more, tasse ...)
- Ordini
- Preventivi
- Rapporti d'intervento

### Ruolo: Co-Admin

Se il ruolo dell'utente è impostato su <code>co-admin</code>, allora l'utente potrà eseguire tutte le funzionalità dell'utente <code>admin</code>, tranne la modifica e la scelta del ruolo degli utenti. \
L'utente <code>co-admin</code> potrà ***aggiungere*** e ***modificare*** un utente, ma non potrà scegliere il ruolo. Di default il ruolo dell'utente creato sarà <code>default</code>.

### Ruolo: Default

Se il ruolo dell'utente è impostato su <code>default</code>, allora l'utente potrà eseguire solo funzioni Aggiunta/Modifica/Eliminazione di:
- Rapporti d'intervento
- Ordini
- Preventivi
- ...

# Fatture

- [ ] Completato

EvoSpan sarà anche in grado di creare le fatture con un look totalmente personalizzato. \
Dal colore, allo stile del font ... dai nomi delle voci, agli spazi tra una tabella e un'altra. \
All'installazione del software verrà chiesto di inserire il **nome dell'azienda** e il **logo**, questi due dati infatti verrano salvati per poi essere inseriti in fatture, documenti, modelli grafici ecc...

# Promemoria calendario

- [ ] Completato

EvoSpan avrà anche un calendario dove si potranno vedere tutti gli appuntamenti/eventi/ecc... presi con i clienti, in più gli/l' utente/i che saranno coinvolti nell'appuntamento presente nel calendario verranno notificati sull'applicazione mobile.

- Decidere se far scegliere all'utente quando essere notificato:
    - Il giorno prima;
    - 5 minuti prima;
    - Una settimana prima;
    - ...

# Magazzino

- [ ] Completato

All'interno di EvoSPan sarà presente un magazzino dove poter inserire i prodotti:
- Nome prodotto
- Codice univoco
- Fornitore
- Prezzo a listino
- Prezzo di vendita
- (se presente) Anni di Garanzia

Oltre ai prodotti, si possono anche inserire i servizi:
- Nome servizio
- Codice univoco
- Utenti che applicano questo servizio
- Prezzo per unità:
    - Ore
    - Pezzi
    - Minuti
    - ...

> I prezzi per i servizi possono anche essere omessi poiché verrà calcolato \
> in base al costo per ora dall'utente inserito (se presente).

