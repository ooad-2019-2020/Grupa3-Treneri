# Grupa3-Treneri
Tema: Fitness centar

Naruèilac želi da automatizira, ubrza i poboljša rad teretane. Ciljevi su sljedeæi:
-	Omoguæavanje kartiènog i gotovinskog plaæanja èlanskih karti (uživo) te omoguæavanje kartiènog plaæanja od kuæe 
	(prilikom online uèlanjivanja)
-	Èlanska karta æe uvijek biti spremna dan poslije uèlanjivanja u 12:00pm te se šalje notifikacija korisniku koju 
	on onda može podiæi bilo kad nakon toga
-	Dodavanje opcija za mjeseène, tromjeseène i godišnje èlanarine
-	Omoguæavanje iznajmljivanja opreme na maksimalno 15 dana
-	Dodavanje moguænosti da se vidi koje sprave su u kojem trenutku zauzete i na koji vremenski period na naèin da 
	svako ko želi koristi nešto mora to zabilježiti preko sistema, kao i trenutni broj prisutnih u odnosu na maksimalan 
	kapacitet ljudi 
-	Dodavanje moguænosti pregleda i prijavljivanja na grupne ili pojedinaène vježbe preko sistema (u taèno odreðenim 
	navedenim terminima u toku sedmice kod odabranog trenera)
-	Voðenje evidencije o dolascima korisnika, te ukoliko neko koristi teretanu 85% dana u mjesecu dobija jednu mjeseènu 
	èlanarinu gratis

Kao što se može zakljuèiti iz navedenog razmatranja, postoje razlièite vrste korisnika koji mogu pristupiti sistemu i to: 
Recepcioneri (imaju prava administratora sistema), treneri (imaju malo ogranièenija prava), uèlanjeni korisnici te korisnici 
koji nemaju vlastite profile nego samo traže odreðene informacije. U nastavku æemo detaljno objasniti uloge svih korisnika 
te njihove naèine pristupanja.

Korisnici koji nisu uèlanjeni imaju pristup samo homepage-u na kojem su prikazane informacije o radu teretane kao što su: 
radni dani, radno vrijeme, lokacija, treneri i slièno. Ima opciju online uèlanjivanja ali nije obavezno.

Uèlanjeni korisnici, bez obzira na to da li su se uèlanili uživo ili online, imaju opciju da sa homepage preðu u korisnièki pogled. 
Nakon prijave na svoje profile imaju moguænost da prate sljedeæe: prikaz raspoložive opreme za iznajmljivanje te ukoliko je taj 
korisnik veæ iznajmio nešto, onda prikaz krajnjeg roka za vraæanje opreme (kada rok isteke korisnik dobija notifikaciju), opciju 
za rezervaciju individualnih ili grupnih treninga kod odabranog trenera u odabranom terminu, prikaz trenutne raspoloživosti teretane 
i trenutno raspoloživih sprava, dok se moguænost da zauzme opremu javlja kao opcija tek onda kada recepcioner zabilježi prisustvo 
u teretani. Takoðer, korisnik može pratiti evidenciju svoje aktivnosti u smislu da mu se prikazuje broj dolazaka u teretanu, kao i 
procenat dana u odnosu na broj dana u tom mjesecu za vrijeme kojih je korisnik dolazio u teretanu te ukoliko se doðe do 85%, korisnik 
dobija nagradu (besplatna mjeseèna èlanarina). Ukoliko korisniku istekne èlanarina, obnavljanje se može obaviti na isti naèin kao 
uèlanjenje, na licu mjesta ili online.

Treneri nakon prijavljivanja na svoje naloge mogu vidjeti za koje termine ima prijavljenih èlanova, te koji su to èlanovi.

Recepcioner je zaslužen za obavljanje uèlanjivanja korisnika, a dobija i notifikacije kada se neki novi èlan online prijavi. 
Na kraju radnog vremena svakog dana šalje izvještaj o broju èlanskih kartica i imena ljudi za koje su, te mu se iste dostavljaju 
sutradan u 12. U svakom trenutku ima pristup broju uèlanjenih, kao i njihovim podacima. Recepcija je takoðer zadužena za evidentiranje 
iznajmljene opreme (ovu funkcionalnost nema korisnik direktno preko svog profila) na naèin da unose podatke o iznajmljenoj opremi, 
datumu iznajmljivanja (rok se automatski raèuna), te podatke o korisniku koji je iznajmio opremu. Pored dužnosti evidentiranja, u svakom 
trenutku može pristupiti izvještaju o trenutno iznajmljenim, kao i raspoloživim spravama. Što se tièe zauzetosti odreðene opreme u teretani, 
recepcioner je dužan samo zabilježiti koji je korisnik trenutno prisutan u teretani nakon èega se korisniku javlja opcija da bilježi koju 
spravu trenutno zauzima. Recepcioner pored toga može samo pristupiti izvještaju o tome koje sprave su zauzete, do kada i od strane koga. 
Recepcioner takoðer bilježi odlazak korisnika, pri èemu se korisniku oduzimaju navedene privilegije. Može pristupiti podacima o 
grupnim/pojedinaènim treninzima za taj dan na naèin da vidi koji trener je odgovoran za koji trening, kao i spisak svih prijavljenih 
èlanova za odreðene termine.


Zahtjeve navedene na poèetku dokumenta æemo sada tekstualno malo detaljnije opisati:

Uèlanjivanje
Ukoliko se korisnik uèlanjuje preko online servisa dužan je popuniti prijavu „Sign up“, gdje unosi svoje podatke kako što su: 
ime, prezime, e-mail adresa, username i password, nakon èega se prelazi na odabit vrste èlanarine, te se prikazuje interfejs 
za unos podataka za kartièno plaæanje. Ukoliko se korisnik odluèi na uèlanjivanje uživo na recepciji, korisnik recepcioneru 
daje sljedeæe informacije: ime, prezime i e-mail adresu, nakon èega je potrebno da korisnik izvrši plaæanje odgovarajuæe vrste 
èlanarine, te se generišu username i password i šalju korisniku na mail. Svaki novi èlan se dodaje u izvještaj koji poslije služi 
za kreiranje odgovarajuæe èlanske kartice.

Rezervacija treninga
U sluèaju da se korisnik želi prijaviti za grupni ili individualni trening prikazuje mu se interfejs koji nudi da odabere jednu 
od te dvije opcije. Nakon odabrane opcije, prikazuje se spisak slobodnih termina iz te oblasti zajedno sa odgovarajuæim trenerima 
za te termine. Korisniku se nudi opcija da otkaže prijavljeni termin, ali najkasnije 24 sata prije poèetka termina.

Iznajmljivanje opreme
U sluèaju da korisnik želi iznajmiti neku opremu, može preko svog profila provjeriti šta je slobodno za iznajmljivanje ili može 
direktno pitati na recepciji. Recepcioner bilježi podatke korisnika koji iznajmljuje opremu, kao i oznaku (serijski broj) opreme, 
nakon èega se iznajmljena oprema automatski oznaèava kao zauzeta. Po povratku opreme, recepcioner ju oznaèava kao slobodnu. 
Kako je maksimalni rok iznajmljivanja 15 dana, korisniku se šalju upozorenja 3 dana i 1 dan pred istek roka, kao i na dan isteka roka 
da je vrijeme da vrati što je iznajmio.

Korištenje opreme
Svaki korisnik koji je trenutno u teretani, što je zabilježeno od strane recepcionera, mora ili putem nekog vlastitog ureðaja ili putem 
ureðaja u teretani zabilježiti koju spravu koristi putem njenog serijskog broja i takoðer mora navesti vremenski interval tokom kojeg æe 
tu spravu koristiti. Taj vremenski interval se od strane istog korisnika može korigovati po potrebi. Kada korisnik zauzme neku spravu za 
korištenje ona bude oznaèena kao zauzeta te ostali korisnici mogu pristupiti toj informaciji.

