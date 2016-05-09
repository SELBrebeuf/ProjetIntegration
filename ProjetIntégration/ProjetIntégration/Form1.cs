using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetIntégration
{
    public partial class Form1 : Form
    {
        #region Variables

        //Score
        int tynenol = 0;
        int advil = 0;
        int aleve = 0;
        int asperin = 0;
        bool tynenolOK = true;
        bool advilOK = true;
        bool aleveOK = true;
        bool asperinOK = true;
        string resultatFinal;
        string reponse = "";

        //Page Age
        string ageEntrer;
        int ageChiffre;

        //Page Sexe
        bool homme = false;
        bool femme = false;

        //Page Femme
        bool enceinte = false;
        bool enceinteNon = false;
        bool allaite = false;
        bool allaiteNon = false;
        bool trismetre1 = false;
        bool trimestre2 = false;
        bool trimestre3 = false;

        //Page Raisons
        bool dysménorrhée = false;
        bool dos = false;
        bool cou = false;
        bool courbatures = false;
        bool chirurgie = false;
        bool dentaire = false;
        bool oreille = false;
        bool tete = false;
        bool physique = false;
        bool fievre = false;
        bool sanguin = false;
        bool cardiovasculaire = false;
        bool fibrillation = false;
        bool infarctus = false;
        bool pericardite = false;
        bool arteriel = false;
        bool valve = false;
        bool ischemie = false;
        bool thrombo = false;
        bool thromboVeineuse = false;
        bool arthrose = false;
        bool autre = false;

        //Page Chirurgie
        bool chirurgie57joursOui = false;
        bool chirurgie57joursNon = false;

        //Page Médicaments
        bool autreAnal = false;
        bool metho = false;
        bool antico = false;
        bool autreMedic = false;
        bool aucunMedic = false;

        //Page Allergies
        bool amidon = false;
        bool hypromellose = false;
        bool cellulose = false;
        bool triacétine = false;
        bool AAS = false;
        bool stéarate = false;
        bool polyéthylèneglycol = false;
        bool providone = false;
        bool dioxyneTitane = false;
        bool talc = false;
        bool naproxène = false;
        bool méfénamique = false;
        bool monoglyceride = false;
        bool cireAbeille = false;
        bool cireCarnauba = false;
        bool croscarmellose = false;
        bool ironOxides = false;
        bool lecithin = false;
        bool parabens = false;
        bool pharmaink = false;
        bool starch = false;
        bool shellac = false;
        bool silicone = false;
        bool benzoate = false;
        bool lauryl = false;
        bool stearic = false;
        bool sucrose = false;
        bool ibuprofène = false;
        bool glycolate = false;
        bool acétaminophène = false;
        bool salicylique = false;
        bool tiaprofénique = false;
        bool bromfénac = false;
        bool célécoxib = false;
        bool diclofénac = false;
        bool diflunisal = false;
        bool étodolac = false;
        bool fénoprofène = false;
        bool floctafénine = false;
        bool flurbiprofène = false;
        bool indométhacine = false;
        bool kétoprofène = false;
        bool kétorolac = false;
        bool lumiracoxib = false;
        bool méloxicam = false;
        bool mésalamine = false;
        bool nabumétone = false;
        bool népafénac = false;
        bool olsalazine = false;
        bool oxaprozine = false;
        bool oxyphenbutazone = false;
        bool phénylbutazone = false;
        bool piroxicam = false;
        bool rofécoxib = false;
        bool salicylamide = false;
        bool salicylates = false;
        bool salsalate = false;
        bool subsalicylate = false;
        bool sulfasalazine = false;
        bool sulindac = false;
        bool ténoxicam = false;
        bool tolmétine = false;
        bool valdécoxib = false;
        bool aucuneAllergie = false;

        //Page Problèmes
        bool rénale = false;
        bool hépatique = false;
        bool inflammationNasales = false;
        bool alcoolisme = false;
        bool déshydratation = false;
        bool hyperkaliémie = false;
        bool lupus = false;
        bool oedème = false;
        bool gastroIntestinaux = false;
        bool gastrite = false;
        bool ulcères = false;
        bool saignement = false;
        bool sanguins = false;
        bool thrombocytopénie = false;
        bool hémophilie = false;
        bool anémie = false;
        bool hémorragie = false;
        bool troublesCardiaques = false;
        bool insuffisanceCardiaque = false;
        bool icc = false;
        bool coronarien = false;
        bool avc = false;
        bool ictProbleme = false;
        bool anginePoitrine = false;
        bool angineInstable = false;
        bool infarctusMyocarde = false;
        bool coronaropathie = false;
        bool hypertension = false;
        bool pontage = false;
        bool aucunprobleme = false;

        //Page Asthme
        bool asthmeOui = false;
        bool asthmeNon = false;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pagePrincipale.Visible = true;
            pagePrincipale.SetBounds(0, 0, 1362, 700);
        }

        #region Page Principale
        private void btnCommencer_Click(object sender, EventArgs e)
        {
            pagePrincipale.Visible = false;
            pageInfos.Visible = true;
            pageInfos.SetBounds(0, 0, 1362, 700);
        }
        #endregion

        #region Page Information
        private void btnContinuerInfo_Click(object sender, EventArgs e)
        {
            pageAge.Visible = true;
            pageInfos.Visible = false;
            pageAge.SetBounds(0, 0, 1362, 700);
        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            pageInfos.Visible = false;
            pagePrincipale.Visible = true;
        }
        #endregion

        #region Page Age
        private void btnRetourAge_Click(object sender, EventArgs e)
        {
            pageAge.Visible = false;
            pageInfos.Visible = true;
        }

        private void btnContinuerAge_Click(object sender, EventArgs e)
        {
            bool verification = Int32.TryParse(ageEntrer, out ageChiffre);

            if (verification)
            {
                if (ageChiffre >= 18 && ageChiffre <= 75)
                {
                    pageAge.Visible = false;
                    pageSexe.Visible = true;
                    pageSexe.SetBounds(0, 0, 1362, 700);
                    if (ageChiffre >= 65)
                    {
                        tynenol++;
                    }
                }
                else
                {
                    errorProviderTextAge.SetError(textBoxAge, "Il est préférable de consulter un médecin avant d'utiliser un analgésique pour l'obtention de recommandations plus spécifiques.");
                }
            }
            else
            {
                errorProviderTextAge.SetError(textBoxAge, "Veuillez entrer un nombre.");
            }

        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            ageEntrer = textBoxAge.Text;
        }
        #endregion

        #region Page Sexe
        private void btnHomme_Click(object sender, EventArgs e)
        {
            btnHomme.Select();
            homme = true;
            femme = false;
        }

        private void btnFemme_Click(object sender, EventArgs e)
        {
            btnFemme.Select();
            homme = false;
            femme = true;
        }

        private void btnContinuerSexe_Click(object sender, EventArgs e)
        {
            if (homme)
            {
                pageSexe.Visible = false;
                pageRaison.Visible = true;
                pageRaison.SetBounds(0, 0, 1362, 700);
            }
            if (femme)
            {
                pageSexe.Visible = false;
                pageFemme.Visible = true;
                pageFemme.SetBounds(0, 0, 1362, 700);
            }
            else
            {
                errorProviderTextAge.SetError(btnContinuerSexe, "Veuillez choisir une réponse.");
            }
        }

        private void btnRetourSexe_Click(object sender, EventArgs e)
        {
            pageSexe.Visible = false;
            pageAge.Visible = true;
        }
        #endregion

        #region Page Femme

        private void btnRetourFemme_Click(object sender, EventArgs e)
        {
            pageFemme.Visible = false;
            pageSexe.Visible = true;
            btnFemme.Select();
        }

        private void btnContinuerFemme_Click(object sender, EventArgs e)
        {
            if ((enceinte || enceinteNon) && (allaite || allaiteNon))
            {
                if (enceinte)
                {
                    if(trismetre1 || trimestre2 || trimestre3)
                    {
                        pageFemme.Visible = false;
                        pageRaison.Visible = true;
                        cBDysménorrhée.Visible = true;
                        pageRaison.SetBounds(0, 0, 1362, 700);
                    }
                    else
                    {
                        errorProviderTextAge.SetError(labelTrimestre, "Veuillez choisir une réponse.");
                    }
                }
                else
                {
                    pageFemme.Visible = false;
                    pageRaison.Visible = true;
                    cBDysménorrhée.Visible = true;
                    pageRaison.SetBounds(0, 0, 1362, 700);
                }
                
                if (enceinte)
                {
                    tynenol++;
                }
                if (allaite)
                {
                    tynenol++;
                    asperinOK = false;
                    advil++;
                }
                if(trismetre1 || trimestre3)
                {
                    aleveOK = false;
                    advilOK = false;

                    if (trimestre3)
                    {
                        asperinOK = false;
                    }
                }
            }
            else
            {
                errorProviderTextAge.SetError(btnContinuerFemme, "Veuillez choisir une réponse.");
            }
        }

        private void radioButtonEnceinteOui_CheckedChanged(object sender, EventArgs e)
        {
            enceinte = radioButtonEnceinteOui.Checked;
            if (enceinte)
            {
                labelTrimestre.Visible = true;
                cb1Trimestre.Visible = true;
                cb2Trimestre.Visible = true;
                cb3Trimestre.Visible = true;
            }
        }

        private void radioButtonAllaiteOui_CheckedChanged(object sender, EventArgs e)
        {
            allaite = radioButtonAllaiteOui.Checked;
        }

        private void radioButtonEnceinteNon_CheckedChanged(object sender, EventArgs e)
        {
            enceinteNon = radioButtonEnceinteNon.Checked;
            if (enceinteNon)
            {
                labelTrimestre.Visible = false;
                cb1Trimestre.Visible = false;
                cb2Trimestre.Visible = false;
                cb3Trimestre.Visible = false;
            }
        }

        private void radioButtonAllaiteNon_CheckedChanged(object sender, EventArgs e)
        {
            allaiteNon = radioButtonAllaiteNon.Checked;
        }


        private void cb1Trimestre_CheckedChanged(object sender, EventArgs e)
        {
            trismetre1 = cb1Trimestre.Checked;
            if (trismetre1)
            {
                cb2Trimestre.Checked = false;
                cb3Trimestre.Checked = false;
            }
        }

        private void cb2Trimestre_CheckedChanged(object sender, EventArgs e)
        {
            trimestre2 = cb2Trimestre.Checked;
            if (trimestre2)
            {
                cb1Trimestre.Checked = false;
                cb3Trimestre.Checked = false;
            }
        }

        private void cb3Trimestre_CheckedChanged(object sender, EventArgs e)
        {
            trimestre3 = cb3Trimestre.Checked;
            if (trimestre3)
            {
                cb1Trimestre.Checked = false;
                cb2Trimestre.Checked = false;
            }
        }
        #endregion

        #region Page Raisons/Mal

        private void cBDysménorrhée_CheckedChanged(object sender, EventArgs e)
        {
            dysménorrhée = cBDysménorrhée.Checked;
        }

        private void cBDos_CheckedChanged(object sender, EventArgs e)
        {
            dos = cBDos.Checked;
        }

        private void cBCou_CheckedChanged(object sender, EventArgs e)
        {
            cou = cBCou.Checked;
        }

        private void cBCourbatures_CheckedChanged(object sender, EventArgs e)
        {
            courbatures = cBCourbatures.Checked;
        }

        private void cBDouleursChirurgie_CheckedChanged(object sender, EventArgs e)
        {
            chirurgie = cBDouleursChirurgie.Checked;
        }

        private void cBDentaire_CheckedChanged(object sender, EventArgs e)
        {
            dentaire = cBDentaire.Checked;
        }

        private void cBOreilles_CheckedChanged(object sender, EventArgs e)
        {
            oreille = cBOreilles.Checked;
        }

        private void cBTete_CheckedChanged(object sender, EventArgs e)
        {
            tete = cBTete.Checked;
        }

        private void cbPhysique_CheckedChanged(object sender, EventArgs e)
        {
            physique = cbPhysique.Checked;
        }

        private void cBFievre_CheckedChanged(object sender, EventArgs e)
        {
            fievre = cBFievre.Checked;
        }
        private void cBCoagulation_CheckedChanged(object sender, EventArgs e)
        {
            sanguin = cBCoagulation.Checked;
        }

        private void cbArthrose_CheckedChanged(object sender, EventArgs e)
        {
            arthrose = cbArthrose.Checked;
        }

        private void cBCardiovasculaire_CheckedChanged(object sender, EventArgs e)
        {
            cardiovasculaire = cBCardiovasculaire.Checked;
            if (cardiovasculaire)
            {
                panelMaladiesCardio.Visible = true;
            }
            else
            {
                panelMaladiesCardio.Visible = false;
            }
        }

        private void cBFibrillationAuri_CheckedChanged(object sender, EventArgs e)
        {
            fibrillation = cBFibrillationAuri.Checked;
        }

        private void cBInfarctus_CheckedChanged(object sender, EventArgs e)
        {
            infarctus = cBInfarctus.Checked;
        }
 
        private void cBPericardite_CheckedChanged(object sender, EventArgs e)
        {
            pericardite = cBPericardite.Checked;
        }

        private void cBCanalArtériel_CheckedChanged(object sender, EventArgs e)
        {
            arteriel = cBCanalArtériel.Checked;
        }

        private void cBValves_CheckedChanged(object sender, EventArgs e)
        {
            valve = cBValves.Checked;
        }

        private void cBICT_CheckedChanged(object sender, EventArgs e)
        {
            ischemie = cBICT.Checked;
        }

        private void cBThromboembolie_CheckedChanged(object sender, EventArgs e)
        {
            thrombo = cBThromboembolie.Checked;
        }

        private void cBThromboseVeineuse_CheckedChanged(object sender, EventArgs e)
        {
            thromboVeineuse = cBThromboseVeineuse.Checked;
        }

        private void cBAutreDouleurs_CheckedChanged(object sender, EventArgs e)
        {
            autre = cBAutreDouleurs.Checked;
        }

        private void btnRetourRaison_Click(object sender, EventArgs e)
        {
            pageRaison.Visible = false;
            pageSexe.Visible = true;
            if (homme)
            {
                btnHomme.Select();
            }
            if (femme)
            {
                btnFemme.Select();
            }
        }

        private void btnContinuerRaison_Click(object sender, EventArgs e)
        {
            
            if(dysménorrhée || dos || cou || courbatures || chirurgie || dentaire || oreille || 
                tete || physique || fievre || sanguin || fibrillation || infarctus || pericardite || 
                arteriel || valve || ischemie || thrombo || thromboVeineuse || arthrose)
            {
                if (dentaire)
                {
                    asperin++;
                    tynenol++;
                    advil++;
                }
                if (tete)
                {
                    asperin++;
                    tynenol++;
                    advil++;
                }
                if (fievre)
                {
                    asperin++;
                    tynenol++;
                    advil++;
                }
                if (sanguin || fibrillation || infarctus || pericardite || valve || ischemie ||
                    thrombo || thromboVeineuse)
                {
                    tynenolOK = false;
                    advilOK = false;
                    aleveOK = false;
                }
                if (arteriel)
                {
                    tynenolOK = false;
                    asperinOK = false;
                    aleveOK = false;
                }

                pageRaison.Visible = false;
                pageChirurgie.Visible = true;
                pageChirurgie.SetBounds(0, 0, 1362, 700);
            }
            else if (autre)
            {
                pageRaison.Visible = false;
                pageAutre.Visible = true;
                pageAutre.SetBounds(0, 0, 1362, 700);
            }
            else
            {
                errorProviderTextAge.SetError(btnContinuerRaison, "Veuillez choisir une réponse.");
            }
        }
        #endregion

        #region Page Si Autre raison sélectionnée
        private void btnRetourAutre_Click(object sender, EventArgs e)
        {
            pageAutre.Visible = false;
            pagePrincipale.Visible = true;
        }
        #endregion

        #region Page Chirurgie 5@7 jours

        private void btnRetourChirurgie_Click(object sender, EventArgs e)
        {
            pageChirurgie.Visible = false;
            pageRaison.Visible = true;
        }

        private void btnContinuerChirurgie_Click(object sender, EventArgs e)
        {
            if (chirurgie57joursOui || chirurgie57joursNon)
            {
                if (chirurgie57joursOui)
                {
                    asperinOK = false;
                }

                pageChirurgie.Visible = false;
                pageMedication.Visible = true;
                pageMedication.SetBounds(0, 0, 1362, 700);
            }
            else
            {
                errorProviderTextAge.SetError(btnContinuerChirurgie, "Veuillez choisir une réponse.");
            }
        }

        private void rBChirurgie5JourOui_CheckedChanged(object sender, EventArgs e)
        {
            chirurgie57joursOui = rBChirurgie5JourOui.Checked;
        }

        private void rBChirurgie5JourNon_CheckedChanged(object sender, EventArgs e)
        {
            chirurgie57joursNon = rBChirurgie5JourNon.Checked;
        }
        #endregion

        #region Page prise Médicaments

        private void cbAINS_CheckedChanged(object sender, EventArgs e)
        {
            autreAnal = cbAINS.Checked;
            cbAucunMedicaments.Checked = false;
        }

        private void cbMethotrexate_CheckedChanged(object sender, EventArgs e)
        {
            metho = cbMethotrexate.Checked;
            cbAucunMedicaments.Checked = false;
        }

        private void cbAnticoagulant_CheckedChanged(object sender, EventArgs e)
        {
            antico = cbAnticoagulant.Checked;
            cbAucunMedicaments.Checked = false;
        }

        private void cbAutreMedicament_CheckedChanged(object sender, EventArgs e)
        {
            autreMedic = cbAutreMedicament.Checked;
            cbAucunMedicaments.Checked = false;
        }

        private void cbAucunMedicaments_CheckedChanged(object sender, EventArgs e)
        {
            aucunMedic = cbAucunMedicaments.Checked;

            if (autreMedic || autreAnal || metho || antico)
            {
                cbAutreMedicament.Checked = false;
                autreMedic = false;

                cbAINS.Checked = false;
                autreAnal = false;

                cbMethotrexate.Checked = false;
                metho = false;

                cbAnticoagulant.Checked = false;
                antico = false;
            }
        }

        private void btnRetourMedic_Click(object sender, EventArgs e)
        {
            pageMedication.Visible = false;
            pageChirurgie.Visible = true;
        }

        private void btnContinuerMedic_Click(object sender, EventArgs e)
        {
            if(autreAnal || metho || antico || autreMedic || aucunMedic)
            {
                if (autreAnal)
                {
                    aleveOK = false;
                    advilOK = false;
                }
                if (metho)
                {
                    aleveOK = false;
                    asperinOK = false;
                }
                if (antico)
                {
                    tynenolOK = false;
                }
                if (autreMedic)
                {
                    tynenol++;
                }

                pageMedication.Visible = false;
                pageAllergies.Visible = true;
                pageAllergies.SetBounds(0, 0, 1362, 700);
            }
            else
            {
                errorProviderTextAge.SetError(btnContinuerMedic, "Veuillez choisir une réponse.");
            }

        }
        #endregion

        #region Page Allergies
        private void cbAmidon_CheckedChanged(object sender, EventArgs e)
        {
            amidon = cbAmidon.Checked;
        }

        private void cbHypromellose_CheckedChanged(object sender, EventArgs e)
        {
            hypromellose = cbHypromellose.Checked;
        }

        private void cbCellulose_CheckedChanged(object sender, EventArgs e)
        {
            cellulose = cbCellulose.Checked;
        }

        private void cbTriacétine_CheckedChanged(object sender, EventArgs e)
        {
            triacétine = cbTriacétine.Checked;
        }

        private void cbAcétylsalicylique_CheckedChanged(object sender, EventArgs e)
        {
            acétaminophène = cbAcétaminophène.Checked;
        }

        private void cbStéarate_CheckedChanged(object sender, EventArgs e)
        {
            stéarate = cbStéarate.Checked;
        }

        private void cbPolyéthylèneglycol_CheckedChanged(object sender, EventArgs e)
        {
            polyéthylèneglycol = cbPolyéthylèneglycol.Checked;
        }

        private void cbProvidone_CheckedChanged(object sender, EventArgs e)
        {
            providone = cbProvidone.Checked;
        }

        private void cbDioTitane_CheckedChanged(object sender, EventArgs e)
        {
            dioxyneTitane = cbDioTitane.Checked;
        }

        private void cbTalc_CheckedChanged(object sender, EventArgs e)
        {
            talc = cbTalc.Checked;
        }

        private void cbMonoglyceride_CheckedChanged(object sender, EventArgs e)
        {
            monoglyceride = cbMonoglyceride.Checked;
        }

        private void cbAbeille_CheckedChanged(object sender, EventArgs e)
        {
            cireAbeille = cbAbeille.Checked;
        }

        private void cbCireCarnauba_CheckedChanged(object sender, EventArgs e)
        {
            cireCarnauba = cbCireCarnauba.Checked;
        }

        private void cbCroscarmellose_CheckedChanged(object sender, EventArgs e)
        {
            croscarmellose = cbCroscarmellose.Checked;
        }

        private void cbIronOxides_CheckedChanged(object sender, EventArgs e)
        {
            ironOxides = cbIronOxides.Checked;
        }

        private void cbLecithin_CheckedChanged(object sender, EventArgs e)
        {
            lecithin = cbLecithin.Checked;
        }

        private void cbParabens_CheckedChanged(object sender, EventArgs e)
        {
            parabens = cbParabens.Checked;
        }

        private void cbPharmaInk_CheckedChanged(object sender, EventArgs e)
        {
            pharmaink = cbPharmaInk.Checked;
        }

        private void cbStarch_CheckedChanged(object sender, EventArgs e)
        {
            starch = cbStarch.Checked;
        }

        private void cbShellac_CheckedChanged(object sender, EventArgs e)
        {
            shellac = cbShellac.Checked;
        }

        private void cbSilicone_CheckedChanged(object sender, EventArgs e)
        {
            silicone = cbSilicone.Checked;
        }

        private void cbBenzoate_CheckedChanged(object sender, EventArgs e)
        {
            benzoate = cbBenzoate.Checked;
        }

        private void cbLauryl_CheckedChanged(object sender, EventArgs e)
        {
            lauryl = cbLauryl.Checked;
        }

        private void cbStearic_CheckedChanged(object sender, EventArgs e)
        {
            stearic = cbStearic.Checked;
        }

        private void cbSucrose_CheckedChanged(object sender, EventArgs e)
        {
            sucrose = cbSucrose.Checked;
        }

        private void cbIbuprofène_CheckedChanged(object sender, EventArgs e)
        {
            ibuprofène = cbIbuprofène.Checked;
        }

        private void cbGlycolate_CheckedChanged(object sender, EventArgs e)
        {
            glycolate = cbGlycolate.Checked;
        }

        private void cbAcétaminophène_CheckedChanged(object sender, EventArgs e)
        {
            acétaminophène = cbAcétaminophène.Checked;
        }

        private void cbMéfénamique_CheckedChanged(object sender, EventArgs e)
        {
            méfénamique = cbMéfénamique.Checked;
        }

        private void cbSalicylique_CheckedChanged(object sender, EventArgs e)
        {
            salicylique = cbSalicylique.Checked;
        }

        private void cbTiaprofénique_CheckedChanged(object sender, EventArgs e)
        {
            tiaprofénique = cbTiaprofénique.Checked;
        }

        private void cbBromfénaque_CheckedChanged(object sender, EventArgs e)
        {
            bromfénac = cbBromfénaque.Checked;
        }

        private void cbCélécoxib_CheckedChanged(object sender, EventArgs e)
        {
            célécoxib = cbCélécoxib.Checked;
        }

        private void cbDiclofénac_CheckedChanged(object sender, EventArgs e)
        {
            diclofénac = cbDiclofénac.Checked;
        }

        private void cbDiflunisal_CheckedChanged(object sender, EventArgs e)
        {
            diflunisal = cbDiclofénac.Checked;
        }

        private void cbÉtodolac_CheckedChanged(object sender, EventArgs e)
        {
            étodolac = cbÉtodolac.Checked;
        }

        private void cbFénoprofène_CheckedChanged(object sender, EventArgs e)
        {
            fénoprofène = cbFénoprofène.Checked;
        }

        private void cbFloctafénine_CheckedChanged(object sender, EventArgs e)
        {
            floctafénine = cbFloctafénine.Checked;
        }

        private void cbFlurbiprofène_CheckedChanged(object sender, EventArgs e)
        {
            flurbiprofène = cbFlurbiprofène.Checked;
        }

        private void cbIndométhacine_CheckedChanged(object sender, EventArgs e)
        {
            indométhacine = cbIndométhacine.Checked;
        }

        private void cbKétoprofène_CheckedChanged(object sender, EventArgs e)
        {
            kétoprofène = cbKétoprofène.Checked;
        }

        private void cbKétorolac_CheckedChanged(object sender, EventArgs e)
        {
            kétoprofène = cbKétoprofène.Checked;
        }

        private void cbLumiracoxib_CheckedChanged(object sender, EventArgs e)
        {
            lumiracoxib = cbLumiracoxib.Checked;
        }

        private void cbMéloxicam_CheckedChanged(object sender, EventArgs e)
        {
            méloxicam = cbMéloxicam.Checked;
        }

        private void cbMésalamine_CheckedChanged(object sender, EventArgs e)
        {
            mésalamine = cbMésalamine.Checked;
        }

        private void cbNabumétone_CheckedChanged(object sender, EventArgs e)
        {
            nabumétone = cbNabumétone.Checked;
        }

        private void cbNaproxène_CheckedChanged(object sender, EventArgs e)
        {
            naproxène = cbNaproxène.Checked;
        }

        private void cbNépafénac_CheckedChanged(object sender, EventArgs e)
        {
            népafénac = cbNépafénac.Checked;
        }

        private void cbOlsalazine_CheckedChanged(object sender, EventArgs e)
        {
            olsalazine = cbOlsalazine.Checked;
        }

        private void cbOxaprozine_CheckedChanged(object sender, EventArgs e)
        {
            oxaprozine = cbOxaprozine.Checked;
        }

        private void cbOxyphenbutazone_CheckedChanged(object sender, EventArgs e)
        {
            oxyphenbutazone = cbOxyphenbutazone.Checked;
        }

        private void cbPhénylbutazone_CheckedChanged(object sender, EventArgs e)
        {
            phénylbutazone = cbPhénylbutazone.Checked;
        }

        private void cbPiroxicam_CheckedChanged(object sender, EventArgs e)
        {
            piroxicam = cbPiroxicam.Checked;
        }

        private void cbRofécoxib_CheckedChanged(object sender, EventArgs e)
        {
            rofécoxib = cbRofécoxib.Checked;
        }

        private void cbSalicylamide_CheckedChanged(object sender, EventArgs e)
        {
            salicylamide = cbSalicylamide.Checked;
        }

        private void cbSalicylates_CheckedChanged(object sender, EventArgs e)
        {
            salicylates = cbSalicylates.Checked;
        }

        private void cbSalsalate_CheckedChanged(object sender, EventArgs e)
        {
            salsalate = cbSalsalate.Checked;
        }

        private void cbSubsalicylate_CheckedChanged(object sender, EventArgs e)
        {
            subsalicylate = cbSubsalicylate.Checked;
        }

        private void cbSulfasalazine_CheckedChanged(object sender, EventArgs e)
        {
            sulfasalazine = cbSulfasalazine.Checked;
        }

        private void cbSulindac_CheckedChanged(object sender, EventArgs e)
        {
            sulindac = cbSulindac.Checked;
        }

        private void cbTénoxicam_CheckedChanged(object sender, EventArgs e)
        {
            ténoxicam = cbTénoxicam.Checked;
        }

        private void cbTolmétine_CheckedChanged(object sender, EventArgs e)
        {
            tolmétine = cbTolmétine.Checked;
        }

        private void cbValdécoxib_CheckedChanged(object sender, EventArgs e)
        {
            valdécoxib = cbValdécoxib.Checked;
        }

        private void cbAucune_CheckedChanged(object sender, EventArgs e)
        {
            aucuneAllergie = cbAucune.Checked;
        }
        private void btnContinuerAllergies_Click(object sender, EventArgs e)
        {
            if (amidon || hypromellose || cellulose || triacétine || AAS || stéarate ||
                polyéthylèneglycol || providone || dioxyneTitane || talc || naproxène ||
                méfénamique || monoglyceride || cireAbeille || cireCarnauba || croscarmellose ||
                ironOxides || lecithin || parabens || pharmaink || starch || shellac || silicone ||
                benzoate || lauryl || stearic || sucrose || ibuprofène || glycolate || acétaminophène ||
                salicylique || tiaprofénique || bromfénac || célécoxib || diclofénac || diflunisal ||
                étodolac || fénoprofène || floctafénine || flurbiprofène || indométhacine || kétoprofène ||
                kétorolac || lumiracoxib || méloxicam || mésalamine || nabumétone || népafénac ||
                olsalazine || oxaprozine || oxyphenbutazone || phénylbutazone || piroxicam || rofécoxib ||
                salicylamide || salicylates || salsalate || subsalicylate || sulfasalazine || sulindac ||
                ténoxicam || tolmétine || valdécoxib || aucuneAllergie)
            {
                if (amidon)
                {
                    tynenolOK = false;
                    asperinOK = false;
                    advilOK = false;
                }
                if (hypromellose)
                {
                    tynenolOK = false;
                    aleveOK = false;
                    asperinOK = false;
                }
                if (cellulose)
                {
                    tynenolOK = false;
                    aleveOK = false;
                    asperinOK = false;
                    advilOK = false;
                }
                if (triacétine)
                {
                    asperinOK = false;
                }
                if (AAS || ibuprofène || salicylique || tiaprofénique || bromfénac || célécoxib || diclofénac || 
                diflunisal || étodolac || fénoprofène || floctafénine || flurbiprofène || indométhacine || 
                kétoprofène || kétorolac || lumiracoxib || méloxicam || mésalamine || nabumétone || 
                népafénac || olsalazine || oxaprozine || oxyphenbutazone || phénylbutazone || piroxicam || 
                rofécoxib || salicylamide || salicylates || salsalate || subsalicylate || sulfasalazine || 
                sulindac || ténoxicam || tolmétine || valdécoxib)
                {
                    asperinOK = false;
                    aleveOK = false;
                    advilOK = false;
                }
                if (stéarate)
                {
                    aleveOK = false;
                    tynenolOK = false;
                }
                if (polyéthylèneglycol)
                {
                    aleveOK = false;
                    tynenolOK = false;
                }
                if (providone || dioxyneTitane)
                {
                    aleveOK = false;
                    advilOK = false;
                }
                if(talc || naproxène)
                {
                    aleveOK = false;
                }
                if (méfénamique)
                {
                    aleveOK = false;
                    advilOK = false;
                    asperinOK = false;
                }
                if (monoglyceride || cireAbeille || cireCarnauba || croscarmellose || ironOxides ||
                    lecithin || parabens || starch || shellac || benzoate || lauryl || stearic || sucrose)
                {
                    advilOK = false;
                }
                if (pharmaink)
                {
                    advilOK = false;
                    aleveOK = false;
                }
                if (glycolate || acétaminophène)
                {
                    tynenolOK = false;
                }

                pageAllergies.Visible = false;
                pageProblèmes.Visible = true;
                pageProblèmes.SetBounds(0, 0, 1362, 700);

            }
            else
            {
                errorProviderTextAge.SetError(btnContinuerAllergies, "Veuillez choisir une réponse.");
            }
        }

        private void btnRetourAllergies_Click(object sender, EventArgs e)
        {
            pageAllergies.Visible = false;
            pageMedication.Visible = true;
        }

        #endregion

        #region Page Pathologique/Problèmes

        private void cbRénale_CheckedChanged(object sender, EventArgs e)
        {
            rénale = cbRénale.Checked;
        }

        private void cbHépatique_CheckedChanged(object sender, EventArgs e)
        {
            hépatique = cbHépatique.Checked;
        }

        private void cbInflammationNasales_CheckedChanged(object sender, EventArgs e)
        {
            inflammationNasales = cbInflammationNasales.Checked;
        }

        private void cbAlcoolisme_CheckedChanged(object sender, EventArgs e)
        {
            alcoolisme = cbAlcoolisme.Checked;
        }

        private void cbDéshydratation_CheckedChanged(object sender, EventArgs e)
        {
            déshydratation = cbDéshydratation.Checked;
        }

        private void cbHyperkaliémie_CheckedChanged_1(object sender, EventArgs e)
        {
            hyperkaliémie = cbHyperkaliémie.Checked;
        }

        private void cbLupus_CheckedChanged(object sender, EventArgs e)
        {
            lupus = cbLupus.Checked;
        }

        private void cbOedème_CheckedChanged(object sender, EventArgs e)
        {
            oedème = cbOedème.Checked;
        }

        private void cbGastroIntestinaux_CheckedChanged(object sender, EventArgs e)
        {
            gastroIntestinaux = cbGastroIntestinaux.Checked;
            if (gastroIntestinaux)
            {
                panelGastroIntestinaux.Visible = true;
            }
            else
            {
                panelGastroIntestinaux.Visible = false;
            }
        }

        private void cbGastrite_CheckedChanged(object sender, EventArgs e)
        {
            gastrite = cbGastrite.Checked;
        }

        private void cbUlcères_CheckedChanged(object sender, EventArgs e)
        {
            ulcères = cbUlcères.Checked;
        }

        private void cbSaignementGastro_CheckedChanged(object sender, EventArgs e)
        {
            saignement = cbSaignementGastro.Checked;
        }

        private void cbSanguins_CheckedChanged(object sender, EventArgs e)
        {
            sanguins = cbSanguins.Checked;
            if (sanguins)
            {
                panelTroublesSanguins.Visible = true;
            }
            else
            {
                panelTroublesSanguins.Visible = false;
            }
        }

        private void cbThrombocytopénie_CheckedChanged(object sender, EventArgs e)
        {
            thrombocytopénie = cbThrombocytopénie.Checked;
        }

        private void cbHémophilie_CheckedChanged(object sender, EventArgs e)
        {
            hémophilie = cbHémophilie.Checked;
        }

        private void cbAnémie_CheckedChanged(object sender, EventArgs e)
        {
            anémie = cbAnémie.Checked;
        }

        private void cbHémorragie_CheckedChanged(object sender, EventArgs e)
        {
            hémorragie = cbHémorragie.Checked;
        }

        private void cbTroublesCardiaques_CheckedChanged(object sender, EventArgs e)
        {
            troublesCardiaques = cbTroublesCardiaques.Checked;
            if (troublesCardiaques)
            {
                panelTroublesCardiaques.Visible = true;
            }
            else
            {
                panelTroublesCardiaques.Visible = false;
            }
        }


        private void cbCardiaque_CheckedChanged(object sender, EventArgs e)
        {
            insuffisanceCardiaque = cbCardiaque.Checked;
        }

        private void cbICC_CheckedChanged(object sender, EventArgs e)
        {
            icc = cbICC.Checked;
        }

        private void cbCoronarien_CheckedChanged(object sender, EventArgs e)
        {
            coronarien = cbCoronarien.Checked;
        }

        private void cbAVC_CheckedChanged(object sender, EventArgs e)
        {
            avc = cbAVC.Checked;
        }

        private void cbICTProblemes_CheckedChanged(object sender, EventArgs e)
        {
            ictProbleme = cbICTProblemes.Checked;
        }

        private void cbAnginePoitrine_CheckedChanged(object sender, EventArgs e)
        {
            anginePoitrine = cbAnginePoitrine.Checked;
        }

        private void cbAngineInstable_CheckedChanged(object sender, EventArgs e)
        {
            angineInstable = cbAngineInstable.Checked;
        }

        private void cbInfarctusMyocarde_CheckedChanged(object sender, EventArgs e)
        {
            infarctusMyocarde = cbInfarctusMyocarde.Checked;
        }

        private void cbCoronaropathie_CheckedChanged(object sender, EventArgs e)
        {
            coronaropathie = cbCoronaropathie.Checked;
        }

        private void cbHypertension_CheckedChanged(object sender, EventArgs e)
        {
            hypertension = cbHypertension.Checked;
        }

        private void cbPontage_CheckedChanged(object sender, EventArgs e)
        {
            pontage = cbPontage.Checked;
        }

        private void cbAucunProbleme_CheckedChanged(object sender, EventArgs e)
        {
            aucunprobleme = cbAucunProbleme.Checked;
        }

        private void btnRetourProblèmes_Click(object sender, EventArgs e)
        {
            pageProblèmes.Visible = false;
            pageAllergies.Visible = true;
        }

        private void btnContinuerProblèmes_Click(object sender, EventArgs e)
        {

            if (rénale || hépatique || inflammationNasales || alcoolisme ||déshydratation ||
                hyperkaliémie || lupus || oedème || gastrite || ulcères || saignement || 
                thrombocytopénie || hémophilie || anémie || hémorragie || insuffisanceCardiaque || icc || 
                coronarien || avc || ictProbleme || anginePoitrine || angineInstable || infarctusMyocarde || 
                coronaropathie || hypertension || pontage || aucunprobleme)
            {
                if (rénale)
                {
                    asperinOK = false;
                    advilOK = false;
                    aleveOK = false;
                }
                if (hépatique)
                {
                    asperinOK = false;
                    advilOK = false;
                    aleveOK = false;
                    tynenolOK = false;
                }
                if (inflammationNasales)
                {
                    advilOK = false;
                    asperinOK = false;
                }
                if (alcoolisme)
                {
                    asperinOK = false;
                    advilOK = false;
                    aleveOK = false;
                    tynenolOK = false;
                }
                if (déshydratation)
                {
                    advilOK = false;
                    aleveOK = false;
                }
                if (hyperkaliémie || coronarien || avc || ictProbleme || anginePoitrine || 
                    angineInstable || infarctusMyocarde || coronaropathie || pontage)
                {
                    aleveOK = false;
                }
                if (lupus || oedème)
                {
                    advilOK = false;
                }
                if (gastrite)
                {
                    asperinOK = false;
                    tynenol++;
                }
                if (ulcères)
                {
                    advilOK = false;
                    aleveOK = false;
                    asperinOK = false;
                }
                if(saignement)
                {
                    aleveOK = false;
                    advilOK = false;
                    asperinOK = false;
                }
                if (thrombocytopénie)
                {
                    asperinOK = false;
                    aleveOK = false;
                }
                if (hémophilie || hémorragie)
                {
                    aleveOK = false;
                    asperinOK = false;
                }
                if (anémie || icc)
                {
                    asperinOK = false;
                }
                if (insuffisanceCardiaque || hypertension)
                {
                    aleveOK = false;
                    advilOK = false;
                }

             

                pageProblèmes.Visible = false;
                pageAsthme.Visible = true;
                pageAsthme.SetBounds(0, 0, 1362, 700);
            }
            else
            {
                errorProviderTextAge.SetError(btnContinuerProblèmes, "Veuillez choisir une réponse.");
            }
        }
        #endregion

        #region Page Asthme
        private void rbAsthmeOui_CheckedChanged(object sender, EventArgs e)
        {
            asthmeOui = rbAsthmeOui.Checked;
        }

        private void rbAsthmeNon_CheckedChanged(object sender, EventArgs e)
        {
            asthmeNon = rbAsthmeNon.Checked;
        }

        private void btnRetourAsthme_Click(object sender, EventArgs e)
        {
            pageAsthme.Visible = false;
            pageProblèmes.Visible = true;
        }

        private void btnContinuerAsthme_Click(object sender, EventArgs e)
        {
            if (asthmeOui || asthmeNon)
            {
                if (asthmeOui)
                {
                    advilOK = false;
                    aleveOK = false;
                    asperinOK = false;
                }

                pageAsthme.Visible = false;
                labelFinal.Visible = false;
                pageFinale.Visible = true;
                pageFinale.SetBounds(0, 0, 1362, 700);
            }
            else
            {
                errorProviderTextAge.SetError(btnContinuerAsthme, "Veuillez choisir une réponse.");
            }
        }
        #endregion

        #region Page Finale

        #region calculs double
        private string tynenolAleve()
        {
            if(tynenolOK && aleveOK)
            {
                if (tynenol > aleve)
                {
                    reponse =  "Tynenol";
                }
                else if (tynenol < aleve)
                {
                    reponse =  "Aleve";
                }
                else if(tynenol == aleve)
                {
                    reponse =  "Tynenol ou Aleve";
                }
            }
   
            return reponse;
        }

        private string tynenolAspirine()
        {
            if (tynenolOK && asperinOK)
            {
                if (tynenol > asperin)
                {
                    reponse = "Tynenol";
                }
                else if (tynenol < asperin)
                {
                    reponse = "Aspirine";
                }
                else if (tynenol == asperin)
                {
                    reponse = "Tynenol ou Aspirine";
                }
            }
            return reponse;
        }

        private string tynenolAdvil()
        {
            if (tynenolOK && advilOK)
            {
                if (tynenol > advil)
                {
                    reponse = "Tynenol";
                }
                else if (tynenol < advil)
                {
                    reponse = "Advil";
                }
                else if (tynenol == advil)
                {
                    reponse = "Tynenol ou Advil";
                }
            }
            return reponse;
        }

        private string aleveAspirine()
        {
            if (aleveOK && asperinOK)
            {
                if (aleve > asperin)
                {
                    reponse = "Aleve";
                }
                else if (aleve < asperin)
                {
                    reponse = "Aspirine";
                }
                else if (aleve == asperin)
                {
                    reponse = "Aleve ou Aspirine";
                }
            }
            return reponse;
        }

        private string aleveAdvil()
        {
            if (aleveOK && advilOK)
            {
                if (aleve > advil)
                {
                    reponse = "Aleve";
                }
                else if (aleve < advil)
                {
                    reponse = "Advil";
                }
                else if (aleve == advil)
                {
                    reponse = "Aleve ou Advil";
                }
            }
            return reponse;
        }

        private string aspirineAdvil()
        {
            if (asperinOK && advilOK)
            {
                if (asperin > advil)
                {
                    reponse = "Aspirine";
                }
                else if (asperin < advil)
                {
                    reponse = "Advil";
                }
                else if (asperin == advil)
                {
                    reponse = "Aspirine ou Advil";
                }
            }
            return reponse;
        }
        #endregion
        #region calculs triple
        private string tynenolAleveAdvil()
        {
            if (tynenolOK && aleveOK && advilOK)
            {
                if (tynenol > aleve)
                {
                    if(tynenol > advil)
                    {
                        reponse = "Tylenol";
                    }
                    else if(tynenol == advil)
                    {
                        reponse = "Tylenol ou Advil";
                    }
                    else
                    {
                        reponse = "Advil";
                    }
                }
                else if (tynenol == aleve)
                {
                    if (tynenol > advil)
                    {
                        reponse = "Tylenol ou Aleve";
                    }
                    else if(tynenol == advil)
                    {
                        reponse = "Tylenol, Aleve ou Advil";
                    }
                    else
                    {
                        reponse = "Advil";
                    }
                }
                else if (tynenol < aleve)
                {
                    if(aleve > advil)
                    {
                        reponse = "Aleve";
                    }
                    else if(aleve == advil)
                    {
                        reponse = "Aleve ou Advil";
                    }
                    else
                    {
                        reponse = "Advil";
                    }
                }
            }

            return reponse;
        }

        private string tynenolAleveAspirine()
        {
            if (tynenolOK && aleveOK && asperinOK)
            {
                if (tynenol > aleve)
                {
                    if (tynenol > asperin)
                    {
                        reponse = "Tylenol";
                    }
                    else if (tynenol == asperin)
                    {
                        reponse = "Tylenol ou Aspirine";
                    }
                    else
                    {
                        reponse = "Aspirine";
                    }
                }
                else if (tynenol == aleve)
                {
                    if (tynenol > asperin)
                    {
                        reponse = "Tylenol ou Aleve";
                    }
                    else if (tynenol == asperin)
                    {
                        reponse = "Tylenol, Aleve ou Aspirine";
                    }
                    else
                    {
                        reponse = "Aspirine";
                    }
                }
                else if (tynenol < aleve)
                {
                    if (aleve > asperin)
                    {
                        reponse = "Aleve";
                    }
                    else if (aleve == asperin)
                    {
                        reponse = "Aleve ou Aspirine";
                    }
                    else
                    {
                        reponse = "Aspirine";
                    }
                }
            }

            return reponse;
        }

        private string tynenolAdvilAspirine()
        {
            if (tynenolOK && advilOK && asperinOK)
            {
                if (tynenol > advil)
                {
                    if (tynenol > asperin)
                    {
                        reponse = "Tylenol";
                    }
                    else if (tynenol == asperin)
                    {
                        reponse = "Tylenol ou Aspirine";
                    }
                    else
                    {
                        reponse = "Aspirine";
                    }
                }
                else if (tynenol == advil)
                {
                    if (tynenol > asperin)
                    {
                        reponse = "Tylenol ou Advil";
                    }
                    else if (tynenol == asperin)
                    {
                        reponse = "Tylenol, Advil ou Aspirine";
                    }
                    else
                    {
                        reponse = "Aspirine";
                    }
                }
                else if (tynenol < advil)
                {
                    if (advil > asperin)
                    {
                        reponse = "Advil";
                    }
                    else if (advil == asperin)
                    {
                        reponse = "Advil ou Aspirine";
                    }
                    else
                    {
                        reponse = "Aspirine";
                    }
                }
            }

            return reponse;
        }

        private string aleveAdvilAspirine()
        {
            if (aleveOK && advilOK && asperinOK)
            {
                if (aleve > advil)
                {
                    if (aleve > asperin)
                    {
                        reponse = "Aleve";
                    }
                    else if (aleve == asperin)
                    {
                        reponse = "Aleve ou Aspirine";
                    }
                    else
                    {
                        reponse = "Aspirine";
                    }
                }
                else if (aleve == advil)
                {
                    if (aleve > asperin)
                    {
                        reponse = "Aleve ou Advil";
                    }
                    else if (aleve == asperin)
                    {
                        reponse = "Aleve, Advil ou Aspirine";
                    }
                    else
                    {
                        reponse = "Aspirine";
                    }
                }
                else if (aleve < advil)
                {
                    if (advil > asperin)
                    {
                        reponse = "Advil";
                    }
                    else if (advil == asperin)
                    {
                        reponse = "Advil ou Aspirine";
                    }
                    else
                    {
                        reponse = "Aspirine";
                    }
                }
            }

            return reponse;
        }
        #endregion
        #region calculs quarubles
        private string tynenolAleveAdvilAspirine()
        {
            if (tynenolOK && aleveOK && advilOK && asperinOK)
            {
                if (tynenol > aleve)
                {
                    if (tynenol > advil)
                    {
                        if (tynenol > asperin)
                        {
                            reponse = "Tylenol";
                        }
                        else if(tynenol == asperin)
                        {
                            reponse = "Tylenol ou Aspirine";
                        }
                        else
                        {
                            reponse = "Aspirine";
                        }
                    }
                    else if(tynenol == advil)
                    {
                        if(tynenol > asperin)
                        {
                            reponse = "Tylenol ou Advil";
                        }
                        else if (tynenol == asperin)
                        {
                            reponse = "Tylenol, Advil ou Aspirine";
                        }
                        else
                        {
                            reponse = "Aspirine";
                        }
                    }
                    else if(tynenol < advil)
                    {
                        if(advil > asperin)
                        {
                            reponse = "Advil";
                        }
                        else if(advil == asperin)
                        {
                            reponse = "Advil ou Aspirine";
                        }
                        else
                        {
                            reponse = "Aspirine";
                        }
                    }
                }
                else if(tynenol == aleve)
                {
                    if (tynenol > advil)
                    {
                        if (tynenol > asperin)
                        {
                            reponse = "Tylenol ou Aleve";
                        }
                        else if (tynenol == asperin)
                        {
                            reponse = "Tylenol, Aleve ou Aspirine";
                        }
                        else
                        {
                            reponse = "Aspirine";
                        }
                    }
                    else if (tynenol == advil)
                    {
                        if (tynenol > asperin)
                        {
                            reponse = "Tylenol, Aleve ou Advil";
                        }
                        else if (tynenol == asperin)
                        {
                            reponse = "Tylenol, Aleve, Advil ou Aspirine";
                        }
                        else
                        {
                            reponse = "Aspirine";
                        }
                    }
                    else if (tynenol < advil)
                    {
                        if (advil > asperin)
                        {
                            reponse = "Advil";
                        }
                        else if (advil == asperin)
                        {
                            reponse = "Advil ou Aspirine";
                        }
                        else
                        {
                            reponse = "Aspirine";
                        }
                    }
                }
                else if(tynenol < aleve)
                {
                    if (aleve > advil)
                    {
                        if (aleve > asperin)
                        {
                            reponse = "Aleve";
                        }
                        else if (aleve == asperin)
                        {
                            reponse = "Aleve ou Aspirine";
                        }
                        else
                        {
                            reponse = "Aspirine";
                        }
                    }
                    else if (aleve == advil)
                    {
                        if (aleve > asperin)
                        {
                            reponse = "Aleve ou Advil";
                        }
                        else if (aleve == asperin)
                        {
                            reponse = "Aleve, Advil ou Aspirine";
                        }
                        else
                        {
                            reponse = "Aspirine";
                        }
                    }
                    else if (aleve < advil)
                    {
                        if (advil > asperin)
                        {
                            reponse = "Advil";
                        }
                        else if (advil == asperin)
                        {
                            reponse = "Advil ou Aspirine";
                        }
                        else
                        {
                            reponse = "Aspirine";
                        }
                    }
                }
            }

            return reponse;
        }
        #endregion

        private void btnCalculRésultats_Click(object sender, EventArgs e)
        {
            bool bonResultat = true;
            #region Une possibilité
            if( (advilOK && !aleveOK && !tynenolOK && !asperinOK) ||
                (!advilOK && aleveOK && !tynenolOK && !asperinOK) ||
                (!advilOK && !aleveOK && tynenolOK && !asperinOK) ||
                (!advilOK && !aleveOK && !tynenolOK && asperinOK))
            {
                if (advilOK)
                {
                     resultatFinal = "Advil";
                }
                else if (aleveOK)
                {
                    resultatFinal = "Aleve";
                }
                else if (tynenolOK)
                {
                    resultatFinal = "Tylenol";
                }
                else
                {
                    resultatFinal = "Aspirine";
                }
            }
            #endregion

            #region Deux possibilités 
            //Tynenol-Aleve / Tynenol-Advil / Tynenol-Aspirine / Aleve-Advil / Aleve-Aspirine / Advil-Aspirine
            else if ((tynenolOK && aleveOK && !advilOK && !asperinOK) ||
                     (tynenolOK && !aleveOK && advilOK && !asperinOK) ||
                     (tynenolOK && !aleveOK && !advilOK && asperinOK) ||
                     (!tynenolOK && aleveOK && advilOK && !asperinOK) ||
                     (!tynenolOK && aleveOK && !advilOK && asperinOK) ||
                     (!tynenolOK && !aleveOK && advilOK && asperinOK))
            {
                resultatFinal = tynenolAleve();
                resultatFinal = tynenolAdvil();
                resultatFinal = tynenolAspirine();
                resultatFinal = aleveAdvil();
                resultatFinal = aleveAspirine();
                resultatFinal = aspirineAdvil();
            }
            #endregion

            #region Trois possibilités

            else if ((tynenolOK && aleveOK && advilOK && !asperinOK) ||
                     (tynenolOK && aleveOK && !advilOK && asperinOK) ||
                     (tynenolOK && !aleveOK && advilOK && asperinOK) ||
                     (!tynenolOK && aleveOK && advilOK && asperinOK))
            {
                resultatFinal = tynenolAleveAdvil();
                resultatFinal = tynenolAleveAspirine();
                resultatFinal = tynenolAdvilAspirine();
                resultatFinal = aleveAdvilAspirine();
            }
            #endregion

            #region Quatre possibilités
            else if (tynenolOK && aleveOK && advilOK && asperinOK)
            {
                resultatFinal = tynenolAleveAdvilAspirine();
            }
            #endregion

            #region Aucune possibilité 
            else
            {
                bonResultat = false;
                resultatFinal = "Nous n'avons pas trouver d'antidouleurs appropriés pour vous. Veuillez consulter un médecin.";
            }
            #endregion

            if (bonResultat)
            {
                labelFinal.Text = "Le meilleur antidouleurs pour vous est : " + resultatFinal;
            }
            else
            {
                labelFinal.Text = resultatFinal;
            }

            labelFinal.Visible = true;
        }
        private void btnTerminerResultats_Click(object sender, EventArgs e)
        {
            pageFinale.Visible = false;
            pagePrincipale.Visible = true;
            
            //Score
            tynenol = 0;
            advil = 0;
            aleve = 0;
            asperin = 0;
            tynenolOK = true;
            advilOK = true;
            aleveOK = true;
            asperinOK = true;
            resultatFinal = " ";
            reponse = " ";    

            textBoxAge.Text = "";
            homme = false;
            femme = false;

            #region Page Femme
            radioButtonEnceinteOui.Checked = false;
            radioButtonEnceinteNon.Checked = false;
            radioButtonAllaiteOui.Checked = false;
            radioButtonAllaiteNon.Checked = false;
            labelTrimestre.Visible = false;
            cb1Trimestre.Visible = false;
            cb2Trimestre.Visible = false;
            cb3Trimestre.Visible = false;
            cb1Trimestre.Checked = false;
            cb2Trimestre.Checked = false;
            cb3Trimestre.Checked = false;
            enceinte = false;
            enceinteNon = false;
            allaite = false;
            allaiteNon = false;
            trismetre1 = false;
            trimestre2 = false;
            trimestre3 = false;
            #endregion

            #region Page Raisons/Mal
            cBDysménorrhée.Checked = false;
            cBDos.Checked = false;
            cBCou.Checked = false;
            cBCourbatures.Checked = false;
            cBDouleursChirurgie.Checked = false;
            cBDentaire.Checked = false;
            cBOreilles.Checked = false;
            cBTete.Checked = false;
            cbPhysique.Checked = false;
            cBFievre.Checked = false;
            cBCoagulation.Checked = false;
            cbArthrose.Checked = false;
            cBCardiovasculaire.Checked = false;
            cBFibrillationAuri.Checked = false;
            cBInfarctus.Checked = false;
            cBPericardite.Checked = false;
            cBCanalArtériel.Checked = false;
            cBValves.Checked = false;
            cBICT.Checked = false;
            cBThromboembolie.Checked = false;
            cBThromboseVeineuse.Checked = false;
            cBAutreDouleurs.Checked = false;
            dysménorrhée = false;
            dos = false;
            cou = false;
            courbatures = false;
            chirurgie = false;
            dentaire = false;
            oreille = false;
            tete = false;
            physique = false;
            fievre = false;
            sanguin = false;
            cardiovasculaire = false;
            fibrillation = false;
            infarctus = false;
            pericardite = false;
            arteriel = false;
            valve = false;
            ischemie = false;
            thrombo = false;
            thromboVeineuse = false;
            arthrose = false;
            autre = false;
            #endregion

            #region Page Chirurgie
            rBChirurgie5JourOui.Checked = false;
            rBChirurgie5JourNon.Checked = false;
            chirurgie57joursOui = false;
            chirurgie57joursNon = false;
            #endregion

            #region Page Médicaments
            cbAINS.Checked = false;
            cbMethotrexate.Checked = false;
            cbAnticoagulant.Checked = false;
            cbAutreMedicament.Checked = false;
            cbAucunMedicaments.Checked = false;
            autreAnal = false;
            metho = false;
            antico = false;
            autreMedic = false;
            aucunMedic = false;
            #endregion

            #region Page Allergies
            cbAmidon.Checked = false;
            cbHypromellose.Checked = false;
            cbCellulose.Checked = false;
            cbTriacétine.Checked = false;
            cbAcétaminophène.Checked = false;
            cbStéarate.Checked = false;
            cbPolyéthylèneglycol.Checked = false;
            cbProvidone.Checked = false;
            cbDioTitane.Checked = false;
            cbTalc.Checked = false;
            cbMonoglyceride.Checked = false;
            cbAbeille.Checked = false;
            cbCireCarnauba.Checked = false;
            cbCroscarmellose.Checked = false;
            cbIronOxides.Checked = false;
            cbLecithin.Checked = false;
            cbParabens.Checked = false;
            cbPharmaInk.Checked = false;
            cbStarch.Checked = false;
            cbShellac.Checked = false;
            cbSilicone.Checked = false;
            cbBenzoate.Checked = false;
            cbLauryl.Checked = false;
            cbStearic.Checked = false;
            cbSucrose.Checked = false;
            cbIbuprofène.Checked = false;
            cbGlycolate.Checked = false;
            cbAcétaminophène.Checked = false;
            cbMéfénamique.Checked = false;
            cbSalicylique.Checked = false;
            cbTiaprofénique.Checked = false;
            cbBromfénaque.Checked = false;
            cbCélécoxib.Checked = false;
            cbDiclofénac.Checked = false;
            cbDiclofénac.Checked = false;
            cbÉtodolac.Checked = false;
            cbFénoprofène.Checked = false;
            cbFloctafénine.Checked = false;
            cbFlurbiprofène.Checked = false;
            cbIndométhacine.Checked = false;
            cbKétoprofène.Checked = false;
            cbKétoprofène.Checked = false;
            cbLumiracoxib.Checked = false;
            cbMéloxicam.Checked = false;
            cbMésalamine.Checked = false;
            cbNabumétone.Checked = false;
            cbNaproxène.Checked = false;
            cbNépafénac.Checked = false;
            cbOlsalazine.Checked = false;
            cbOxaprozine.Checked = false;
            cbOxyphenbutazone.Checked = false;
            cbPhénylbutazone.Checked = false;
            cbPiroxicam.Checked = false;
            cbRofécoxib.Checked = false;
            cbSalicylamide.Checked = false;
            cbSalicylates.Checked = false;
            cbSalsalate.Checked = false;
            cbSubsalicylate.Checked = false;
            cbSulfasalazine.Checked = false;
            cbSulindac.Checked = false;
            cbTénoxicam.Checked = false;
            cbTolmétine.Checked = false;
            cbValdécoxib.Checked = false;
            cbAucune.Checked = false;
            amidon = false;
            hypromellose = false;
            cellulose = false;
            triacétine = false;
            AAS = false;
            stéarate = false;
            polyéthylèneglycol = false;
            providone = false;
            dioxyneTitane = false;
            talc = false;
            naproxène = false;
            méfénamique = false;
            monoglyceride = false;
            cireAbeille = false;
            cireCarnauba = false;
            croscarmellose = false;
            ironOxides = false;
            lecithin = false;
            parabens = false;
            pharmaink = false;
            starch = false;
            shellac = false;
            silicone = false;
            benzoate = false;
            lauryl = false;
            stearic = false;
            sucrose = false;
            ibuprofène = false;
            glycolate = false;
            acétaminophène = false;
            salicylique = false;
            tiaprofénique = false;
            bromfénac = false;
            célécoxib = false;
            diclofénac = false;
            diflunisal = false;
            étodolac = false;
            fénoprofène = false;
            floctafénine = false;
            flurbiprofène = false;
            indométhacine = false;
            kétoprofène = false;
            kétorolac = false;
            lumiracoxib = false;
            méloxicam = false;
            mésalamine = false;
            nabumétone = false;
            népafénac = false;
            olsalazine = false;
            oxaprozine = false;
            oxyphenbutazone = false;
            phénylbutazone = false;
            piroxicam = false;
            rofécoxib = false;
            salicylamide = false;
            salicylates = false;
            salsalate = false;
            subsalicylate = false;
            sulfasalazine = false;
            sulindac = false;
            ténoxicam = false;
            tolmétine = false;
            valdécoxib = false;
            aucuneAllergie = false;
            #endregion

            #region Page Problemes
            cbRénale.Checked = false;
            cbHépatique.Checked = false;
            cbInflammationNasales.Checked = false;
            cbAlcoolisme.Checked = false;
            cbDéshydratation.Checked = false;
            cbHyperkaliémie.Checked = false;
            cbLupus.Checked = false;
            cbOedème.Checked = false;
            cbGastroIntestinaux.Checked = false;
            cbGastrite.Checked = false;
            cbUlcères.Checked = false;
            cbSaignementGastro.Checked = false;
            cbSanguins.Checked = false;
            cbThrombocytopénie.Checked = false;
            cbHémophilie.Checked = false;
            cbAnémie.Checked = false;
            cbHémorragie.Checked = false;
            cbTroublesCardiaques.Checked = false;
            cbCardiaque.Checked = false;
            cbICC.Checked = false;
            cbCoronarien.Checked = false;
            cbAVC.Checked = false;
            cbICTProblemes.Checked = false;
            cbAnginePoitrine.Checked = false;
            cbAngineInstable.Checked = false;
            cbInfarctusMyocarde.Checked = false;
            cbCoronaropathie.Checked = false;
            cbHypertension.Checked = false;
            cbPontage.Checked = false;
            cbAucunProbleme.Checked = false;
            rénale = false;
            hépatique = false;
            inflammationNasales = false;
            alcoolisme = false;
            déshydratation = false;
            hyperkaliémie = false;
            lupus = false;
            oedème = false;
            gastroIntestinaux = false;
            gastrite = false;
            ulcères = false;
            saignement = false;
            sanguins = false;
            thrombocytopénie = false;
            hémophilie = false;
            anémie = false;
            hémorragie = false;
            troublesCardiaques = false;
            insuffisanceCardiaque = false;
            icc = false;
            coronarien = false;
            avc = false;
            ictProbleme = false;
            anginePoitrine = false;
            angineInstable = false;
            infarctusMyocarde = false;
            coronaropathie = false;
            hypertension = false;
            pontage = false;
            aucunprobleme = false;
            #endregion

            #region Page Asthme
            rbAsthmeNon.Checked = false;
            rbAsthmeOui.Checked = false;
            asthmeOui = false;
            asthmeNon = false;
            #endregion
        }
        #endregion

    }
}
