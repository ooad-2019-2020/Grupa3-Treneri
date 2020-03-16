# Grupa3-Treneri
Tema: Fitness centar

Naru�ilac �eli da automatizira, ubrza i pobolj�a rad teretane. Ciljevi su sljede�i:
-	Omogu�avanje karti�nog i gotovinskog pla�anja �lanskih karti (u�ivo) te omogu�avanje karti�nog pla�anja od ku�e 
	(prilikom online u�lanjivanja)
-	�lanska karta �e uvijek biti spremna dan poslije u�lanjivanja u 12:00pm te se �alje notifikacija korisniku koju 
	on onda mo�e podi�i bilo kad nakon toga
-	Dodavanje opcija za mjese�ne, tromjese�ne i godi�nje �lanarine
-	Omogu�avanje iznajmljivanja opreme na maksimalno 15 dana
-	Dodavanje mogu�nosti da se vidi koje sprave su u kojem trenutku zauzete i na koji vremenski period na na�in da 
	svako ko �eli koristi ne�to mora to zabilje�iti preko sistema, kao i trenutni broj prisutnih u odnosu na maksimalan 
	kapacitet ljudi 
-	Dodavanje mogu�nosti pregleda i prijavljivanja na grupne ili pojedina�ne vje�be preko sistema (u ta�no odre�enim 
	navedenim terminima u toku sedmice kod odabranog trenera)
-	Vo�enje evidencije o dolascima korisnika, te ukoliko neko koristi teretanu 85% dana u mjesecu dobija jednu mjese�nu 
	�lanarinu gratis

Kao �to se mo�e zaklju�iti iz navedenog razmatranja, postoje razli�ite vrste korisnika koji mogu pristupiti sistemu i to: 
Recepcioneri (imaju prava administratora sistema), treneri (imaju malo ograni�enija prava), u�lanjeni korisnici te korisnici 
koji nemaju vlastite profile nego samo tra�e odre�ene informacije. U nastavku �emo detaljno objasniti uloge svih korisnika 
te njihove na�ine pristupanja.

Korisnici koji nisu u�lanjeni imaju pristup samo homepage-u na kojem su prikazane informacije o radu teretane kao �to su: 
radni dani, radno vrijeme, lokacija, treneri i sli�no. Ima opciju online u�lanjivanja ali nije obavezno.

U�lanjeni korisnici, bez obzira na to da li su se u�lanili u�ivo ili online, imaju opciju da sa homepage pre�u u korisni�ki pogled. 
Nakon prijave na svoje profile imaju mogu�nost da prate sljede�e: prikaz raspolo�ive opreme za iznajmljivanje te ukoliko je taj 
korisnik ve� iznajmio ne�to, onda prikaz krajnjeg roka za vra�anje opreme (kada rok isteke korisnik dobija notifikaciju), opciju 
za rezervaciju individualnih ili grupnih treninga kod odabranog trenera u odabranom terminu, prikaz trenutne raspolo�ivosti teretane 
i trenutno raspolo�ivih sprava, dok se mogu�nost da zauzme opremu javlja kao opcija tek onda kada recepcioner zabilje�i prisustvo 
u teretani. Tako�er, korisnik mo�e pratiti evidenciju svoje aktivnosti u smislu da mu se prikazuje broj dolazaka u teretanu, kao i 
procenat dana u odnosu na broj dana u tom mjesecu za vrijeme kojih je korisnik dolazio u teretanu te ukoliko se do�e do 85%, korisnik 
dobija nagradu (besplatna mjese�na �lanarina). Ukoliko korisniku istekne �lanarina, obnavljanje se mo�e obaviti na isti na�in kao 
u�lanjenje, na licu mjesta ili online.

Treneri nakon prijavljivanja na svoje naloge mogu vidjeti za koje termine ima prijavljenih �lanova, te koji su to �lanovi.

Recepcioner je zaslu�en za obavljanje u�lanjivanja korisnika, a dobija i notifikacije kada se neki novi �lan online prijavi. 
Na kraju radnog vremena svakog dana �alje izvje�taj o broju �lanskih kartica i imena ljudi za koje su, te mu se iste dostavljaju 
sutradan u 12. U svakom trenutku ima pristup broju u�lanjenih, kao i njihovim podacima. Recepcija je tako�er zadu�ena za evidentiranje 
iznajmljene opreme (ovu funkcionalnost nema korisnik direktno preko svog profila) na na�in da unose podatke o iznajmljenoj opremi, 
datumu iznajmljivanja (rok se automatski ra�una), te podatke o korisniku koji je iznajmio opremu. Pored du�nosti evidentiranja, u svakom 
trenutku mo�e pristupiti izvje�taju o trenutno iznajmljenim, kao i raspolo�ivim spravama. �to se ti�e zauzetosti odre�ene opreme u teretani, 
recepcioner je du�an samo zabilje�iti koji je korisnik trenutno prisutan u teretani nakon �ega se korisniku javlja opcija da bilje�i koju 
spravu trenutno zauzima. Recepcioner pored toga mo�e samo pristupiti izvje�taju o tome koje sprave su zauzete, do kada i od strane koga. 
Recepcioner tako�er bilje�i odlazak korisnika, pri �emu se korisniku oduzimaju navedene privilegije. Mo�e pristupiti podacima o 
grupnim/pojedina�nim treninzima za taj dan na na�in da vidi koji trener je odgovoran za koji trening, kao i spisak svih prijavljenih 
�lanova za odre�ene termine.


Zahtjeve navedene na po�etku dokumenta �emo sada tekstualno malo detaljnije opisati:

U�lanjivanje
Ukoliko se korisnik u�lanjuje preko online servisa du�an je popuniti prijavu �Sign up�, gdje unosi svoje podatke kako �to su: 
ime, prezime, e-mail adresa, username i password, nakon �ega se prelazi na odabit vrste �lanarine, te se prikazuje interfejs 
za unos podataka za karti�no pla�anje. Ukoliko se korisnik odlu�i na u�lanjivanje u�ivo na recepciji, korisnik recepcioneru 
daje sljede�e informacije: ime, prezime i e-mail adresu, nakon �ega je potrebno da korisnik izvr�i pla�anje odgovaraju�e vrste 
�lanarine, te se generi�u username i password i �alju korisniku na mail. Svaki novi �lan se dodaje u izvje�taj koji poslije slu�i 
za kreiranje odgovaraju�e �lanske kartice.

Rezervacija treninga
U slu�aju da se korisnik �eli prijaviti za grupni ili individualni trening prikazuje mu se interfejs koji nudi da odabere jednu 
od te dvije opcije. Nakon odabrane opcije, prikazuje se spisak slobodnih termina iz te oblasti zajedno sa odgovaraju�im trenerima 
za te termine. Korisniku se nudi opcija da otka�e prijavljeni termin, ali najkasnije 24 sata prije po�etka termina.

Iznajmljivanje opreme
U slu�aju da korisnik �eli iznajmiti neku opremu, mo�e preko svog profila provjeriti �ta je slobodno za iznajmljivanje ili mo�e 
direktno pitati na recepciji. Recepcioner bilje�i podatke korisnika koji iznajmljuje opremu, kao i oznaku (serijski broj) opreme, 
nakon �ega se iznajmljena oprema automatski ozna�ava kao zauzeta. Po povratku opreme, recepcioner ju ozna�ava kao slobodnu. 
Kako je maksimalni rok iznajmljivanja 15 dana, korisniku se �alju upozorenja 3 dana i 1 dan pred istek roka, kao i na dan isteka roka 
da je vrijeme da vrati �to je iznajmio.

Kori�tenje opreme
Svaki korisnik koji je trenutno u teretani, �to je zabilje�eno od strane recepcionera, mora ili putem nekog vlastitog ure�aja ili putem 
ure�aja u teretani zabilje�iti koju spravu koristi putem njenog serijskog broja i tako�er mora navesti vremenski interval tokom kojeg �e 
tu spravu koristiti. Taj vremenski interval se od strane istog korisnika mo�e korigovati po potrebi. Kada korisnik zauzme neku spravu za 
kori�tenje ona bude ozna�ena kao zauzeta te ostali korisnici mogu pristupiti toj informaciji.

