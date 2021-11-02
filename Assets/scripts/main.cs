using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//using System.Threading;

public class main : MonoBehaviour, IPointerClickHandler
{
    public DateTime date1 = new DateTime();
    public Text logo;
    public bool color = false;
    public Image imagemLogo;
    public Image imagem1;
    public Image imagem2;
    public Image imagem3;
    public Image imagem4;
    public Image imagem5;
    public Image imagem6;
    public Image imagem7;
    public Image imagem8;
    public Image imagem9;
    public Image imagem10;
    public Image imagem11;
    public Image imagem12;
    public Image imagem13;
    public Image imagem14;
    public Image imagem15;
    public Image imagem16;
    public Image imagem17;
    public Image imagem18;
    public Image imagem19;
    public Image imagem20;
    public Image imagem21;
    public Image imagem22;
    public Image imagem23;
    public Image imagem24;
    public Image imagem25;
    public Image imagem26;
    public Image imagem27;
    public Image imagem28;
    public Image imagem29;
    public Image imagem30;
    public Image imagem31;
    public Image imagem32;
    public Image imagem33;
    public Image imagem34;
    public Image imagem35;
    public Image imagem36;
    public Image imagem37;
    public Image imagem38;
    public Image imagem39;
    public Image imagem40;
    public Image imagem41;
    public Image imagem42;
    public Image imagem43;
    public Image imagem44;
    public Image imagem45;
    public Image imagem46;
    public Image imagem47;
    public Image imagem48;
    public Image imagem49;
    public Image imagem50;
    public Image imagem51;
    public Image imagem52;
    public Image imagem53;
    public Image imagem54;
    public Image imagem55;
    public Image imagem56;
    public Image imagem57;
    public Image imagem58;
    public Image imagem59;
    public Image imagem60;
    public Image imagem61;
    public Image imagem62;
    public Image imagem63;
    public Image imagem64;
    public Image imagem65;
    public Image imagem66;
    public Image imagem67;
    public Image imagem68;
    public Image imagem69;
    public Image imagem70;
    public Image imagem71;
    public Image imagem72;
    public Image imagem73;
    public Image imagem74;
    public Image imagem75;
    public Image imagem76;
    public Image imagem77;
    public Image imagem78;
    public Image imagem79;
    public Image imagem80;
    public Image imagem81;
    public Image imagem82;
    public Image imagem83;
    public Image imagem84;
    public Image imagem85;
    public Image imagem86;
    public Image imagem87;
    public Image imagem88;
    public Image imagem89;
    public Image imagem90;
    public Image imagem91;
    public Image imagemPersonagem;
    public Image imagemPersonagemEsquerda;
    public Image imagemPersonagemDireita;
    public Image imagemPersonagemCostas;
    public Image imagemPersonagemFrente;
    public Image imagemCampo;
    public Image imagemTeto;
    public Image imagemTetoBaixo;
    public Image imagemTetoCima;
    public Image imagemTetoEsquerdaCima;
    public Image imagemTetoDireita;
    public Image imagemTetoEsquerda;
    public Image imagemAgua1;
    public Image imagemAgua2;
    public Image imagemAgua3;
    public Image imagemAgua4;
    public Image imagemAgua5;
    public Image imagemAgua6;
    public Image imagemAgua7;
    public Image imagemAgua8;
    public Image imagemAgua9;
    public int teleportNum = 0;
    public Image auxTeleport;
    public Image imagemTeleport;
    public Image imagemTeleport2;
    public Image imagemTeleport3;
    public Image imagemCaixa;
    public Image imagemLixo;
    public Image imagemSacola;
    public Image imagemBuracoNoTeto;
    public Image imagemBuracoAberto;
    public Image imagemBuracoFechado;
    public Image imagemNPC;
    public Image imagemSnake;
    public Image imagemSnakeAtacando;
    public Image imagemSnakeMorta;
    public Image imagemMonstroMorto;
    public Image imagemDragon;
    public Image imagemDragonAtacando;
    public Image imagemMammoth;
    public Image imagemMammothAtacando;
    public Image imagemSpider;
    public Image imagemSpiderAtacando;
    public Image imagemOrcShaman;
    public Image imagemOrcShamanAtacando;
    public bool flagAudio = false;
    public int numAudio = 0;
    public AudioSource audioMain;
    public AudioSource audioCaverna;
    public AudioSource audioCidade;
    public AudioSource audioFloresta;
    public int[] posicaoDoPersonagem = new int[] {4,7};
    public int[] moverPersonagem = new int[] {0,0};

    // Start is called before the first frame update
    void Start()
    {
        date1 = DateTime.Now.AddSeconds(1);

        imagem1.enabled =
        imagem2.enabled =
        imagem3.enabled =
        imagem4.enabled =
        imagem5.enabled =
        imagem6.enabled =
        imagem7.enabled =
        imagem8.enabled =
        imagem9.enabled =
        imagem10.enabled =
        imagem11.enabled =
        imagem12.enabled =
        imagem13.enabled =
        imagem14.enabled =
        imagem15.enabled =
        imagem16.enabled =
        imagem17.enabled =
        imagem18.enabled =
        imagem19.enabled =
        imagem20.enabled =
        imagem21.enabled =
        imagem22.enabled =
        imagem23.enabled =
        imagem24.enabled =
        imagem25.enabled =
        imagem26.enabled =
        imagem27.enabled =
        imagem28.enabled =
        imagem29.enabled =
        imagem30.enabled =
        imagem31.enabled =
        imagem32.enabled =
        imagem33.enabled =
        imagem34.enabled =
        imagem35.enabled =
        imagem36.enabled =
        imagem37.enabled =
        imagem38.enabled =
        imagem39.enabled =
        imagem40.enabled =
        imagem41.enabled =
        imagem42.enabled =
        imagem43.enabled =
        imagem44.enabled =
        imagem45.enabled =
        imagem46.enabled =
        imagem47.enabled =
        imagem48.enabled =
        imagem49.enabled =
        imagem50.enabled =
        imagem51.enabled =
        imagem52.enabled =
        imagem53.enabled =
        imagem54.enabled =
        imagem55.enabled =
        imagem56.enabled =
        imagem57.enabled =
        imagem58.enabled =
        imagem59.enabled =
        imagem60.enabled =
        imagem61.enabled =
        imagem62.enabled =
        imagem63.enabled =
        imagem64.enabled =
        imagem65.enabled =
        imagem66.enabled =
        imagem67.enabled =
        imagem68.enabled =
        imagem69.enabled =
        imagem70.enabled =
        imagem71.enabled =
        imagem72.enabled =
        imagem73.enabled =
        imagem74.enabled =
        imagem75.enabled =
        imagem76.enabled =
        imagem77.enabled =
        imagem78.enabled =
        imagem79.enabled =
        imagem80.enabled =
        imagem81.enabled =
        imagem82.enabled =
        imagem83.enabled =
        imagem84.enabled =
        imagem85.enabled =
        imagem86.enabled =
        imagem87.enabled =
        imagem88.enabled =
        imagem89.enabled =
        imagem90.enabled =
        imagem91.enabled =
        imagemPersonagem.enabled =
        imagemPersonagemEsquerda.enabled =
        imagemPersonagemDireita.enabled =
        imagemPersonagemCostas.enabled =
        imagemPersonagemFrente.enabled =
        imagemCampo.enabled =
        imagemTeto.enabled =
        imagemTetoBaixo.enabled =
        imagemTetoCima.enabled =
        imagemTetoEsquerdaCima.enabled =
        imagemTetoDireita.enabled =
        imagemTetoEsquerda.enabled =
        imagemAgua1.enabled =
        imagemAgua2.enabled =
        imagemAgua3.enabled =
        imagemAgua4.enabled =
        imagemAgua5.enabled =
        imagemAgua6.enabled =
        imagemAgua7.enabled =
        imagemAgua8.enabled =
        imagemAgua9.enabled =
        auxTeleport.enabled =
        imagemTeleport.enabled =
        imagemTeleport2.enabled =
        imagemTeleport3.enabled =
        imagemCaixa.enabled =
        imagemLixo.enabled =
        imagemSacola.enabled =
        imagemBuracoNoTeto.enabled =
        imagemBuracoAberto.enabled =
        imagemBuracoFechado.enabled =
        imagemNPC.enabled =
        imagemSnake.enabled =
        imagemSnakeAtacando.enabled =
        imagemSnakeMorta.enabled =
        imagemMonstroMorto.enabled =
        imagemDragon.enabled =
        imagemDragonAtacando.enabled =
        imagemMammoth.enabled =
        imagemMammothAtacando.enabled =
        imagemSpider.enabled =
        imagemSpiderAtacando.enabled =
        imagemOrcShaman.enabled =
        imagemOrcShamanAtacando.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(date1 < DateTime.Now){
            if(!color){
                logo.color = new Color(0,191,255);
                color = true;
            }else{
                logo.color = new Color(0,1,0);
                color = false;
            }

            if(teleportNum == 0){
                auxTeleport = imagemTeleport;
                teleportNum++;
            }else if(teleportNum == 1){
                auxTeleport = imagemTeleport2;
                teleportNum++;
            }else if(teleportNum == 2){
                auxTeleport = imagemTeleport3;
                teleportNum++;
            }else if(teleportNum == 3){
                auxTeleport = imagemTeleport2;
                teleportNum = 0;
            }

            desenharMapa();

            if(flagAudio){
                if(numAudio != 1 && posicaoDoPersonagem[0] < 44){
                    audioMain.Stop();
                    audioCaverna.Stop();
                    audioCidade.Stop();
                    audioFloresta.Stop();
                    audioCaverna.Play(0);
                    numAudio = 1;
                }else if(numAudio != 2 && posicaoDoPersonagem[0] >= 44 && posicaoDoPersonagem[0] <= 55){
                    audioMain.Stop();
                    audioCaverna.Stop();
                    audioCidade.Stop();
                    audioFloresta.Stop();
                    audioCidade.Play(0);
                    numAudio = 2;
                }else if(numAudio != 3 && posicaoDoPersonagem[0] > 55){
                    audioMain.Stop();
                    audioCaverna.Stop();
                    audioCidade.Stop();
                    audioFloresta.Stop();
                    audioFloresta.Play(0);
                    numAudio = 3;
                }
            }

            date1 = DateTime.Now.AddSeconds(1);
        }
        //Thread.Sleep(1000);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //logo.text = eventData.pointerCurrentRaycast.gameObject.name.ToString();
        //logo.text = eventData.position.x.ToString() + " - " + eventData.position.y.ToString();

        if(eventData.pointerCurrentRaycast.gameObject.name == imagem1.name){
            moverPersonagem[0] = -3; 
            moverPersonagem[1] = -6; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem2.name){
            moverPersonagem[0] = -3; 
            moverPersonagem[1] = -5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem3.name){
            moverPersonagem[0] = -3; 
            moverPersonagem[1] = -4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem4.name){
            moverPersonagem[0] = -3; 
            moverPersonagem[1] = -3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem5.name){
            moverPersonagem[0] = -3; 
            moverPersonagem[1] = -2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem6.name){
            moverPersonagem[0] = -3; 
            moverPersonagem[1] = -1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem7.name){
            moverPersonagem[0] = -3; 
            moverPersonagem[1] = 0; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem8.name){
            moverPersonagem[0] = -3; 
            moverPersonagem[1] = 1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem9.name){
            moverPersonagem[0] = -3; 
            moverPersonagem[1] = 2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem10.name){
            moverPersonagem[0] = -3; 
            moverPersonagem[1] = 3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem11.name){
            moverPersonagem[0] = -3; 
            moverPersonagem[1] = 4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem12.name){
            moverPersonagem[0] = -3; 
            moverPersonagem[1] = 5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem13.name){
            moverPersonagem[0] = -3; 
            moverPersonagem[1] = 6; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem14.name){
            moverPersonagem[0] = -2; 
            moverPersonagem[1] = -6; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem15.name){
            moverPersonagem[0] = -2; 
            moverPersonagem[1] = -5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem16.name){
            moverPersonagem[0] = -2; 
            moverPersonagem[1] = -4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem17.name){
            moverPersonagem[0] = -2; 
            moverPersonagem[1] = -3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem18.name){
            moverPersonagem[0] = -2; 
            moverPersonagem[1] = -2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem19.name){
            moverPersonagem[0] = -2; 
            moverPersonagem[1] = -1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem20.name){
            moverPersonagem[0] = -2; 
            moverPersonagem[1] = 0; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem21.name){
            moverPersonagem[0] = -2; 
            moverPersonagem[1] = 1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem22.name){
            moverPersonagem[0] = -2; 
            moverPersonagem[1] = 2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem23.name){
            moverPersonagem[0] = -2; 
            moverPersonagem[1] = 3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem24.name){
            moverPersonagem[0] = -2; 
            moverPersonagem[1] = 4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem25.name){
            moverPersonagem[0] = -2; 
            moverPersonagem[1] = 5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem26.name){
            moverPersonagem[0] = -2; 
            moverPersonagem[1] = 6; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem27.name){
            moverPersonagem[0] = -1; 
            moverPersonagem[1] = -6; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem28.name){
            moverPersonagem[0] = -1; 
            moverPersonagem[1] = -5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem29.name){
            moverPersonagem[0] = -1; 
            moverPersonagem[1] = -4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem30.name){
            moverPersonagem[0] = -1; 
            moverPersonagem[1] = -3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem31.name){
            moverPersonagem[0] = -1; 
            moverPersonagem[1] = -2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem32.name){
            moverPersonagem[0] = -1; 
            moverPersonagem[1] = -1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem33.name){
            moverPersonagem[0] = -1; 
            moverPersonagem[1] = 0; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem34.name){
            moverPersonagem[0] = -1; 
            moverPersonagem[1] = 1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem35.name){
            moverPersonagem[0] = -1; 
            moverPersonagem[1] = 2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem36.name){
            moverPersonagem[0] = -1; 
            moverPersonagem[1] = 3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem37.name){
            moverPersonagem[0] = -1; 
            moverPersonagem[1] = 4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem38.name){
            moverPersonagem[0] = -1; 
            moverPersonagem[1] = 5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem39.name){
            moverPersonagem[0] = -1; 
            moverPersonagem[1] = 6; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem40.name){
            moverPersonagem[0] = 0; 
            moverPersonagem[1] = -6; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem41.name){
            moverPersonagem[0] = 0; 
            moverPersonagem[1] = -5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem42.name){
            moverPersonagem[0] = 0; 
            moverPersonagem[1] = -4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem43.name){
            moverPersonagem[0] = 0; 
            moverPersonagem[1] = -3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem44.name){
            moverPersonagem[0] = 0; 
            moverPersonagem[1] = -2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem45.name){
            moverPersonagem[0] = 0; 
            moverPersonagem[1] = -1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem46.name){
            moverPersonagem[0] = 0; 
            moverPersonagem[1] = 0; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem47.name){
            moverPersonagem[0] = 0; 
            moverPersonagem[1] = 1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem48.name){
            moverPersonagem[0] = 0; 
            moverPersonagem[1] = 2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem49.name){
            moverPersonagem[0] = 0; 
            moverPersonagem[1] = 3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem50.name){
            moverPersonagem[0] = 0; 
            moverPersonagem[1] = 4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem51.name){
            moverPersonagem[0] = 0; 
            moverPersonagem[1] = 5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem52.name){
            moverPersonagem[0] = 0; 
            moverPersonagem[1] = 6; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem53.name){
            moverPersonagem[0] = 1; 
            moverPersonagem[1] = -6; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem54.name){
            moverPersonagem[0] = 1; 
            moverPersonagem[1] = -5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem55.name){
            moverPersonagem[0] = 1; 
            moverPersonagem[1] = -4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem56.name){
            moverPersonagem[0] = 1; 
            moverPersonagem[1] = -3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem57.name){
            moverPersonagem[0] = 1; 
            moverPersonagem[1] = -2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem58.name){
            moverPersonagem[0] = 1; 
            moverPersonagem[1] = -1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem59.name){
            moverPersonagem[0] = 1; 
            moverPersonagem[1] = 0; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem60.name){
            moverPersonagem[0] = 1; 
            moverPersonagem[1] = 1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem61.name){
            moverPersonagem[0] = 1; 
            moverPersonagem[1] = 2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem62.name){
            moverPersonagem[0] = 1; 
            moverPersonagem[1] = 3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem63.name){
            moverPersonagem[0] = 1; 
            moverPersonagem[1] = 4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem64.name){
            moverPersonagem[0] = 1; 
            moverPersonagem[1] = 5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem65.name){
            moverPersonagem[0] = 1; 
            moverPersonagem[1] = 6; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem66.name){
            moverPersonagem[0] = 2; 
            moverPersonagem[1] = -6; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem67.name){
            moverPersonagem[0] = 2; 
            moverPersonagem[1] = -5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem68.name){
            moverPersonagem[0] = 2; 
            moverPersonagem[1] = -4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem69.name){
            moverPersonagem[0] = 2; 
            moverPersonagem[1] = -3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem70.name){
            moverPersonagem[0] = 2; 
            moverPersonagem[1] = -2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem71.name){
            moverPersonagem[0] = 2; 
            moverPersonagem[1] = -1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem72.name){
            moverPersonagem[0] = 2; 
            moverPersonagem[1] = 0; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem73.name){
            moverPersonagem[0] = 2; 
            moverPersonagem[1] = 1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem74.name){
            moverPersonagem[0] = 2; 
            moverPersonagem[1] = 2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem75.name){
            moverPersonagem[0] = 2; 
            moverPersonagem[1] = 3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem76.name){
            moverPersonagem[0] = 2; 
            moverPersonagem[1] = 4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem77.name){
            moverPersonagem[0] = 2; 
            moverPersonagem[1] = 5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem78.name){
            moverPersonagem[0] = 2; 
            moverPersonagem[1] = 6; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem79.name){
            moverPersonagem[0] = 3; 
            moverPersonagem[1] = -6; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem80.name){
            moverPersonagem[0] = 3; 
            moverPersonagem[1] = -5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem81.name){
            moverPersonagem[0] = 3; 
            moverPersonagem[1] = -4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem82.name){
            moverPersonagem[0] = 3; 
            moverPersonagem[1] = -3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem83.name){
            moverPersonagem[0] = 3; 
            moverPersonagem[1] = -2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem84.name){
            moverPersonagem[0] = 3; 
            moverPersonagem[1] = -1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem85.name){
            moverPersonagem[0] = 3; 
            moverPersonagem[1] = 0; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem86.name){
            moverPersonagem[0] = 3; 
            moverPersonagem[1] = 1; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem87.name){
            moverPersonagem[0] = 3; 
            moverPersonagem[1] = 2; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem88.name){
            moverPersonagem[0] = 3; 
            moverPersonagem[1] = 3; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem89.name){
            moverPersonagem[0] = 3; 
            moverPersonagem[1] = 4; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem90.name){
            moverPersonagem[0] = 3; 
            moverPersonagem[1] = 5; 
        }else if(eventData.pointerCurrentRaycast.gameObject.name == imagem91.name){
            moverPersonagem[0] = 3; 
            moverPersonagem[1] = 6; 
        }

        /*
        if(eventData.position.x < 300){
            imagemPersonagem.sprite = imagemPersonagemEsquerda.sprite;
            moverPersonagem[1] = moverPersonagem[1] - 1; 
        }else if(eventData.position.x > 400){
            imagemPersonagem.sprite = imagemPersonagemDireita.sprite;
            moverPersonagem[1] = moverPersonagem[1] + 1;
        }else if(eventData.position.x > 300 && eventData.position.x < 400 && eventData.position.y > 300){
            imagemPersonagem.sprite = imagemPersonagemCostas.sprite;
            moverPersonagem[0] = moverPersonagem[0] - 1;
        }else if(eventData.position.x > 300 && eventData.position.x < 400 && eventData.position.y < 200){
            imagemPersonagem.sprite = imagemPersonagemFrente.sprite;
            moverPersonagem[0] = moverPersonagem[0] + 1;
        }
        */

        imagem1.enabled =
        imagem2.enabled =
        imagem3.enabled =
        imagem4.enabled =
        imagem5.enabled =
        imagem6.enabled =
        imagem7.enabled =
        imagem8.enabled =
        imagem9.enabled =
        imagem10.enabled =
        imagem11.enabled =
        imagem12.enabled =
        imagem13.enabled =
        imagem14.enabled =
        imagem15.enabled =
        imagem16.enabled =
        imagem17.enabled =
        imagem18.enabled =
        imagem19.enabled =
        imagem20.enabled =
        imagem21.enabled =
        imagem22.enabled =
        imagem23.enabled =
        imagem24.enabled =
        imagem25.enabled =
        imagem26.enabled =
        imagem27.enabled =
        imagem28.enabled =
        imagem29.enabled =
        imagem30.enabled =
        imagem31.enabled =
        imagem32.enabled =
        imagem33.enabled =
        imagem34.enabled =
        imagem35.enabled =
        imagem36.enabled =
        imagem37.enabled =
        imagem38.enabled =
        imagem39.enabled =
        imagem40.enabled =
        imagem41.enabled =
        imagem42.enabled =
        imagem43.enabled =
        imagem44.enabled =
        imagem45.enabled =
        imagem46.enabled =
        imagem47.enabled =
        imagem48.enabled =
        imagem49.enabled =
        imagem50.enabled =
        imagem51.enabled =
        imagem52.enabled =
        imagem53.enabled =
        imagem54.enabled =
        imagem55.enabled =
        imagem56.enabled =
        imagem57.enabled =
        imagem58.enabled =
        imagem59.enabled =
        imagem60.enabled =
        imagem61.enabled =
        imagem62.enabled =
        imagem63.enabled =
        imagem64.enabled =
        imagem65.enabled =
        imagem66.enabled =
        imagem67.enabled =
        imagem68.enabled =
        imagem69.enabled =
        imagem70.enabled =
        imagem71.enabled =
        imagem72.enabled =
        imagem73.enabled =
        imagem74.enabled =
        imagem75.enabled =
        imagem76.enabled =
        imagem77.enabled =
        imagem78.enabled =
        imagem79.enabled =
        imagem80.enabled =
        imagem81.enabled =
        imagem82.enabled =
        imagem83.enabled =
        imagem84.enabled =
        imagem85.enabled =
        imagem86.enabled =
        imagem87.enabled =
        imagem88.enabled =
        imagem89.enabled =
        imagem90.enabled =
        imagem91.enabled =
        imagemPersonagem.enabled = true;

        flagAudio = true;
    }

    public void desenharMapa(){
        /*
        int[,] matrizDoMapa = new int[,] {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,2,3,3,3,4,1,1,1,1,1},
            {1,1,1,1,1,6,0,0,0,4,1,1,1,1,1},
            {1,1,1,1,1,6,0,0,0,4,1,1,1,1,1},
            {1,1,1,1,1,6,0,0,0,4,1,1,1,1,1},
            {1,1,1,1,1,1,5,5,5,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
        }*/

        int[,] matrizDoMapa = new int[,] {
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 2, 3, 3, 3, 1, 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 6, 0, 0,16, 4, 1, 6, 0,16, 0, 0, 0, 0, 0, 0,33, 0, 0,33, 0,33, 0, 0, 0, 0, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 6, 0, 0,19, 4, 1, 6, 0, 0, 0, 0, 0,33, 0, 0, 0, 0,33, 0, 0, 0,33, 0, 0, 0, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 6,20, 0, 0, 4, 1, 6,20, 0, 0, 0, 0, 0, 0, 0,33, 0, 0,33, 0,33, 0, 0, 0, 0, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 5, 5, 5, 1, 1, 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 2, 3, 3, 3, 1, 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 6, 0,18,18, 4, 1, 6, 0, 0, 0, 0, 0, 0, 0, 0,30, 0, 0,30, 0,30, 0, 0, 0, 0, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 6, 0,17,24, 4, 1, 6,20, 0, 0, 0, 0,30, 0, 0, 0, 0,30, 0, 0, 0,30, 0, 0, 0, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 6,21,20,18, 4, 1, 6,21, 0, 0, 0, 0, 0, 0, 0,30, 0, 0,30, 0,30, 0, 0, 0, 0, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 5, 5, 5, 1, 1, 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 2, 3, 3, 3, 1, 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 6,24,17,24, 4, 1, 6, 0, 0, 0, 0, 0, 0, 0, 0,27, 0, 0,27, 0,27, 0, 0, 0, 0, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 6,18, 0,17, 4, 1, 6,21, 0, 0, 0, 0,27, 0, 0, 0, 0,27, 0, 0, 0,27, 0, 0, 0, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 6,18,21,20, 4, 1, 6,20, 0, 0, 0, 0, 0, 0, 0,27, 0, 0,27, 0,27, 0, 0, 0, 0, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 5, 5, 5, 1, 1, 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 2, 3, 3, 3, 1, 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 6,18,24,18, 4, 1, 6, 0, 0, 0, 0, 0, 0, 0, 0,24, 0, 0,24, 0,24, 0, 0, 0, 0, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 6,24,17,20, 4, 1, 6, 0,20, 0, 0, 0,24, 0, 0, 0, 0,24, 0, 0, 0,24, 0, 0, 0, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 6,18,24,21, 4, 1, 6,21, 0, 0, 0, 0, 0, 0, 0,24, 0, 0,24, 0,24, 0, 0, 0, 0, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 5, 5, 5, 1, 1, 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
{ 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9,10, 7, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9,10, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15, 0, 0, 0, 0, 0,19, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,11, 7,15,19,17,17,17,17,27,18,19,17,17,17,17,24,18,19,17,17,17,30,18,17,18,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15,23, 0,22, 0, 0, 0, 0,22, 0, 0, 0, 0, 0, 0, 0, 0,11, 7,15,17,17,27,17,17,17,30,17,17,17,24,17,17,27,17,17,30,17,17,30,17,19,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,13,13,13, 0, 0,11, 7,15,17,24,18,17,17,27,18,17,17,30,18,17,24,18,17,27,18,17,30,18,17,18,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15,18,18, 0, 0, 0, 0, 0, 0, 0,18,18,11, 7,15, 0, 0,11, 7,15,17,17,27,17,17,17,30,17,17,17,24,17,17,27,17,17,30,17,17,30,17, 0,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15,30,17, 0, 0, 0, 0, 0, 0, 0,17,27,11, 7,15, 0, 0,11, 7,15,17,24,18,17,17,27,18,17,17,30,18,17,24,18,17,27,18,17,30,18,17,18,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15,18,18, 0, 0, 0, 0, 0, 0, 0,18,18,11, 7,15, 0, 0,11, 7,15,17,17,27,17,17,17,30,17,17,17,24,17,17,27,17,17,30,17,17,27,17,19,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,11, 7,15, 0, 0,11, 7,15,17,24,18,17,17,27,18,17,17,30,18,17,24,18,17,27,18,17,30,18,17,18,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15,18, 0,18, 0,18, 0,18, 0,18, 0,18,11, 7,15, 0, 0,11, 7,15,17,17,27,17,17,17,30,17,17,17,24,17,17,27,17,17,30,17,17,30,17, 0,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15,30,17,30,17,33,17,33,17,27,17,27,11, 7,15,17,17, 9, 9, 9,17,24,18,17,17,27,18,17,17,30,18,17,24,18,17,27,18,17,30,18,17,18,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15,30,17,30,17,33,17,33,17,27,17,27,11, 7,15, 0, 0, 0, 0,17,17,17,27,17,17,17,30,17,17,17,24,17,17,27,17,17,30,17,17,24,17,19,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15,30,30,30,18,33,33,33,18,27,27,27,11, 7,15, 0, 0, 0, 0,17,17,24,18,19,17,17,17,17,17,30,18,19,17,17,17,27,18,19,17,17,17,18,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,14,13,13,13,13,13,13,13,13,13,13,13,12, 7,15, 0, 0, 0, 0,11,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,12, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7,15, 0, 0, 0, 0,11, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 0, 0, 0, 0,11, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9,10, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,33, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,19,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,33, 0, 0, 0, 0,33, 0, 0, 0, 0,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,33, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,33, 0, 0,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,33, 0, 0, 0, 0, 0, 0, 0, 0,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7,14,13, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,33, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 7, 7,13, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,13,13, 0, 0,13, 0, 0, 0, 0, 0, 0, 0, 0, 0,33, 0, 0, 0, 0,33, 0,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7,13,13, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 7, 7, 7,13, 0, 0,36, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7, 7, 7, 7, 0, 0,33, 0, 0, 0, 0, 0, 0, 0,33, 0, 0,33, 0, 0,11, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 7, 7, 7, 7,13, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,13, 7, 7, 7, 7, 7,19, 0, 0, 0, 0, 0,33, 0, 0, 0, 0, 0, 0, 0, 0,11, 7, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7, 7, 7, 7, 7,13, 0, 0,33, 0, 0, 0, 0, 0, 0, 0,33, 0, 0,19,11, 7, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 7, 7, 7, 7, 7,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13, 7, 7, 7, 7, 7, 7, 7,13,13,13,13,13,13,13,13,13,13,13,13,13,13,12, 7, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7},
{ 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7}
        };

        if(moverPersonagem[1] < 0 && (matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] - 1)] == 0 || matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] - 1)] == 16 || matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] - 1)] == 17 || matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] - 1)] == 20 || matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] - 1)] == 22)){
            if(matrizDoMapa[posicaoDoPersonagem[0],posicaoDoPersonagem[1]] != 17 && matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] - 1)] == 17){
                imagemPersonagem.rectTransform.anchoredPosition = new Vector2(imagemPersonagem.rectTransform.anchoredPosition.x-25, imagemPersonagem.rectTransform.anchoredPosition.y+25);
            }else if(matrizDoMapa[posicaoDoPersonagem[0],posicaoDoPersonagem[1]] == 17 && matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] - 1)] != 17){
                imagemPersonagem.rectTransform.anchoredPosition = new Vector2(imagemPersonagem.rectTransform.anchoredPosition.x+25, imagemPersonagem.rectTransform.anchoredPosition.y-25);
            }
            if(matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] - 1)] == 16){
                posicaoDoPersonagem[0] = posicaoDoPersonagem[0] + 40;
                posicaoDoPersonagem[1] = posicaoDoPersonagem[1] - 1;
                moverPersonagem[1] = 0;
            }else{
                posicaoDoPersonagem[1] = posicaoDoPersonagem[1] - 1;
                moverPersonagem[1] = moverPersonagem[1] + 1;
            }
            imagemPersonagem.sprite = imagemPersonagemEsquerda.sprite;
        }else if(moverPersonagem[1] > 0 && (matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] + 1)] == 0 || matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] + 1)] == 16 || matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] + 1)] == 17 || matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] + 1)] == 20 || matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] + 1)] == 22)){
            if(matrizDoMapa[posicaoDoPersonagem[0],posicaoDoPersonagem[1]] != 17 && matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] + 1)] == 17){
                imagemPersonagem.rectTransform.anchoredPosition = new Vector2(imagemPersonagem.rectTransform.anchoredPosition.x-25, imagemPersonagem.rectTransform.anchoredPosition.y+25);
            }else if(matrizDoMapa[posicaoDoPersonagem[0],posicaoDoPersonagem[1]] == 17 && matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] + 1)] != 17){
                imagemPersonagem.rectTransform.anchoredPosition = new Vector2(imagemPersonagem.rectTransform.anchoredPosition.x+25, imagemPersonagem.rectTransform.anchoredPosition.y-25);
            }
            if(matrizDoMapa[posicaoDoPersonagem[0],(posicaoDoPersonagem[1] + 1)] == 16){
                posicaoDoPersonagem[0] = posicaoDoPersonagem[0] + 40;
                posicaoDoPersonagem[1] = posicaoDoPersonagem[1] + 1;
                moverPersonagem[1] = 0;
            }else{
                posicaoDoPersonagem[1] = posicaoDoPersonagem[1] + 1;
                moverPersonagem[1] = moverPersonagem[1] - 1;
            }
            imagemPersonagem.sprite = imagemPersonagemDireita.sprite;
        }else if(moverPersonagem[0] < 0 && (matrizDoMapa[(posicaoDoPersonagem[0] - 1),posicaoDoPersonagem[1]] == 0 || matrizDoMapa[(posicaoDoPersonagem[0] - 1),posicaoDoPersonagem[1]] == 16 || matrizDoMapa[(posicaoDoPersonagem[0] - 1),posicaoDoPersonagem[1]] == 17 || matrizDoMapa[(posicaoDoPersonagem[0] - 1),posicaoDoPersonagem[1]] == 20 || matrizDoMapa[(posicaoDoPersonagem[0] - 1),posicaoDoPersonagem[1]] == 22)){
            if(matrizDoMapa[posicaoDoPersonagem[0],posicaoDoPersonagem[1]] != 17 && matrizDoMapa[(posicaoDoPersonagem[0] - 1),posicaoDoPersonagem[1]] == 17){
                imagemPersonagem.rectTransform.anchoredPosition = new Vector2(imagemPersonagem.rectTransform.anchoredPosition.x-25, imagemPersonagem.rectTransform.anchoredPosition.y+25);
            }else if(matrizDoMapa[posicaoDoPersonagem[0],posicaoDoPersonagem[1]] == 17 && matrizDoMapa[(posicaoDoPersonagem[0] - 1),posicaoDoPersonagem[1]] != 17){
                imagemPersonagem.rectTransform.anchoredPosition = new Vector2(imagemPersonagem.rectTransform.anchoredPosition.x+25, imagemPersonagem.rectTransform.anchoredPosition.y-25);
            }
            if(matrizDoMapa[(posicaoDoPersonagem[0] - 1),posicaoDoPersonagem[1]] == 16){
                posicaoDoPersonagem[0] = posicaoDoPersonagem[0] + 39;
                moverPersonagem[1] = 0;
            }else{
                posicaoDoPersonagem[0] = posicaoDoPersonagem[0] - 1;
                moverPersonagem[0] = moverPersonagem[0] + 1;
            }
            imagemPersonagem.sprite = imagemPersonagemCostas.sprite;
        }else if(moverPersonagem[0] > 0 && (matrizDoMapa[(posicaoDoPersonagem[0] + 1),posicaoDoPersonagem[1]] == 0 || matrizDoMapa[(posicaoDoPersonagem[0] + 1),posicaoDoPersonagem[1]] == 16 || matrizDoMapa[(posicaoDoPersonagem[0] + 1),posicaoDoPersonagem[1]] == 17 || matrizDoMapa[(posicaoDoPersonagem[0] + 1),posicaoDoPersonagem[1]] == 20 || matrizDoMapa[(posicaoDoPersonagem[0] + 1),posicaoDoPersonagem[1]] == 22)){
            if(matrizDoMapa[posicaoDoPersonagem[0],posicaoDoPersonagem[1]] != 17 && matrizDoMapa[(posicaoDoPersonagem[0] + 1),posicaoDoPersonagem[1]] == 17){
                imagemPersonagem.rectTransform.anchoredPosition = new Vector2(imagemPersonagem.rectTransform.anchoredPosition.x-25, imagemPersonagem.rectTransform.anchoredPosition.y+25);
            }else if(matrizDoMapa[posicaoDoPersonagem[0],posicaoDoPersonagem[1]] == 17 && matrizDoMapa[(posicaoDoPersonagem[0] + 1),posicaoDoPersonagem[1]] != 17){
                imagemPersonagem.rectTransform.anchoredPosition = new Vector2(imagemPersonagem.rectTransform.anchoredPosition.x+25, imagemPersonagem.rectTransform.anchoredPosition.y-25);
            }
            if(matrizDoMapa[(posicaoDoPersonagem[0] + 1),posicaoDoPersonagem[1]] == 16){
                posicaoDoPersonagem[0] = posicaoDoPersonagem[0] + 41;
                moverPersonagem[1] = 0;
            }else{
                posicaoDoPersonagem[0] = posicaoDoPersonagem[0] + 1;
                moverPersonagem[0] = moverPersonagem[0] - 1;
            }
            imagemPersonagem.sprite = imagemPersonagemFrente.sprite;
        }else{
            if(moverPersonagem[1] < 0){
                imagemPersonagem.sprite = imagemPersonagemEsquerda.sprite;
            }else if(moverPersonagem[1] > 0){
                imagemPersonagem.sprite = imagemPersonagemDireita.sprite;
            }else if(moverPersonagem[0] < 0){
                imagemPersonagem.sprite = imagemPersonagemCostas.sprite;
            }else if(moverPersonagem[0] > 0){
                imagemPersonagem.sprite = imagemPersonagemFrente.sprite;
            }

            moverPersonagem[0] = 0;
            moverPersonagem[1] = 0;
        }
        
        //logo.text = posicaoDoPersonagem[0].ToString() + " - " + posicaoDoPersonagem[1];ToString();

        Image auxImagem = imagemLogo;

        for(int i = posicaoDoPersonagem[0]-3; i < posicaoDoPersonagem[0]+4; i++){
            for(int j = posicaoDoPersonagem[1]-6; j < posicaoDoPersonagem[1]+7; j++){
                switch (matrizDoMapa[i,j])
                {
                    case 0:
                        auxImagem = imagemCampo;
                        break;
                    case 1:
                        auxImagem = imagemTeto;
                        break;
                    case 2:
                        auxImagem = imagemTetoEsquerdaCima;
                        break;
                    case 3:
                        auxImagem = imagemTetoCima;
                        break;
                    case 4:
                        auxImagem = imagemTetoDireita;
                        break;
                    case 5:
                        auxImagem = imagemTetoBaixo;
                        break;
                    case 6:
                        auxImagem = imagemTetoEsquerda;
                        break;
                    case 7:
                        auxImagem = imagemAgua1;
                        break;
                    case 8:
                        auxImagem = imagemAgua2;
                        break;
                    case 9:
                        auxImagem = imagemAgua3;
                        break;
                    case 10:
                        auxImagem = imagemAgua4;
                        break;
                    case 11:
                        auxImagem = imagemAgua5;
                        break;
                    case 12:
                        auxImagem = imagemAgua6;
                        break;
                    case 13:
                        auxImagem = imagemAgua7;
                        break;
                    case 14:
                        auxImagem = imagemAgua8;
                        break;
                    case 15:
                        auxImagem = imagemAgua9;
                        break;
                    case 16:
                        auxImagem = auxTeleport;
                        break;
                    case 17:
                        auxImagem = imagemCaixa;
                        break;
                    case 18:
                        auxImagem = imagemLixo;
                        break;
                    case 19:
                        auxImagem = imagemSacola;
                        break;
                    case 20:
                        auxImagem = imagemBuracoNoTeto;
                        break;
                    case 21:
                        auxImagem = imagemBuracoAberto;
                        break;
                    case 22:
                        auxImagem = imagemBuracoFechado;
                        break;
                    case 23:
                        auxImagem = imagemNPC;
                        break;
                    case 24:
                        auxImagem = imagemSnake;
                        break;
                    case 25:
                        auxImagem = imagemSnakeAtacando;
                        break;
                    case 26:
                        auxImagem = imagemSnakeMorta;
                        break;
                    case 27:
                        auxImagem = imagemDragon;
                        break;
                    case 28:
                        auxImagem = imagemDragonAtacando;
                        break;
                    case 29:
                        auxImagem = imagemMonstroMorto;
                        break;
                    case 30:
                        auxImagem = imagemMammoth;
                        break;
                    case 31:
                        auxImagem = imagemMammothAtacando;
                        break;
                    case 32:
                        auxImagem = imagemMonstroMorto;
                        break;
                    case 33:
                        auxImagem = imagemSpider;
                        break;
                    case 34:
                        auxImagem = imagemSnakeAtacando;
                        break;
                    case 35:
                        auxImagem = imagemMonstroMorto;
                        break;
                    case 36:
                        auxImagem = imagemOrcShaman;
                        break;
                    case 37:
                        auxImagem = imagemOrcShamanAtacando;
                        break;
                    case 38:
                        auxImagem = imagemMonstroMorto;
                        break;
                }

                //Debug.Log(i + " - " + j + " pl " + posicaoDoPersonagem[0] + " pc " +  posicaoDoPersonagem[1]);

                if(i == posicaoDoPersonagem[0]-3 && j == posicaoDoPersonagem[1]-6){
                    imagem1.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-3 && j == posicaoDoPersonagem[1]-5){
                    imagem2.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-3 && j == posicaoDoPersonagem[1]-4){
                    imagem3.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-3 && j == posicaoDoPersonagem[1]-3){
                    imagem4.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-3 && j == posicaoDoPersonagem[1]-2){
                    imagem5.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-3 && j == posicaoDoPersonagem[1]-1){
                    imagem6.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-3 && j == posicaoDoPersonagem[1]){
                    imagem7.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-3 && j == posicaoDoPersonagem[1]+1){
                    imagem8.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-3 && j == posicaoDoPersonagem[1]+2){
                    imagem9.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-3 && j == posicaoDoPersonagem[1]+3){
                    imagem10.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-3 && j == posicaoDoPersonagem[1]+4){
                    imagem11.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-3 && j == posicaoDoPersonagem[1]+5){
                    imagem12.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-3 && j == posicaoDoPersonagem[1]+6){
                    imagem13.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-2 && j == posicaoDoPersonagem[1]-6){
                    imagem14.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-2 && j == posicaoDoPersonagem[1]-5){
                    imagem15.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-2 && j == posicaoDoPersonagem[1]-4){
                    imagem16.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-2 && j == posicaoDoPersonagem[1]-3){
                    imagem17.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-2 && j == posicaoDoPersonagem[1]-2){
                    imagem18.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-2 && j == posicaoDoPersonagem[1]-1){
                    imagem19.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-2 && j == posicaoDoPersonagem[1]){
                    imagem20.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-2 && j == posicaoDoPersonagem[1]+1){
                    imagem21.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-2 && j == posicaoDoPersonagem[1]+2){
                    imagem22.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-2 && j == posicaoDoPersonagem[1]+3){
                    imagem23.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-2 && j == posicaoDoPersonagem[1]+4){
                    imagem24.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-2 && j == posicaoDoPersonagem[1]+5){
                    imagem25.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-2 && j == posicaoDoPersonagem[1]+6){
                    imagem26.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-1 && j == posicaoDoPersonagem[1]-6){
                    imagem27.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-1 && j == posicaoDoPersonagem[1]-5){
                    imagem28.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-1 && j == posicaoDoPersonagem[1]-4){
                    imagem29.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-1 && j == posicaoDoPersonagem[1]-3){
                    imagem30.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-1 && j == posicaoDoPersonagem[1]-2){
                    imagem31.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-1 && j == posicaoDoPersonagem[1]-1){
                    imagem32.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-1 && j == posicaoDoPersonagem[1]){
                    imagem33.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-1 && j == posicaoDoPersonagem[1]+1){
                    imagem34.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-1 && j == posicaoDoPersonagem[1]+2){
                    imagem35.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-1 && j == posicaoDoPersonagem[1]+3){
                    imagem36.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-1 && j == posicaoDoPersonagem[1]+4){
                    imagem37.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-1 && j == posicaoDoPersonagem[1]+5){
                    imagem38.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]-1 && j == posicaoDoPersonagem[1]+6){
                    imagem39.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0] && j == posicaoDoPersonagem[1]-6){
                    imagem40.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0] && j == posicaoDoPersonagem[1]-5){
                    imagem41.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0] && j == posicaoDoPersonagem[1]-4){
                    imagem42.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0] && j == posicaoDoPersonagem[1]-3){
                    imagem43.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0] && j == posicaoDoPersonagem[1]-2){
                    imagem44.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0] && j == posicaoDoPersonagem[1]-1){
                    imagem45.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0] && j == posicaoDoPersonagem[1]){
                    imagem46.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0] && j == posicaoDoPersonagem[1]+1){
                    imagem47.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0] && j == posicaoDoPersonagem[1]+2){
                    imagem48.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0] && j == posicaoDoPersonagem[1]+3){
                    imagem49.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0] && j == posicaoDoPersonagem[1]+4){
                    imagem50.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0] && j == posicaoDoPersonagem[1]+5){
                    imagem51.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0] && j == posicaoDoPersonagem[1]+6){
                    imagem52.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+1 && j == posicaoDoPersonagem[1]-6){
                    imagem53.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+1 && j == posicaoDoPersonagem[1]-5){
                    imagem54.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+1 && j == posicaoDoPersonagem[1]-4){
                    imagem55.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+1 && j == posicaoDoPersonagem[1]-3){
                    imagem56.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+1 && j == posicaoDoPersonagem[1]-2){
                    imagem57.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+1 && j == posicaoDoPersonagem[1]-1){
                    imagem58.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+1 && j == posicaoDoPersonagem[1]){
                    imagem59.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+1 && j == posicaoDoPersonagem[1]+1){
                    imagem60.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+1 && j == posicaoDoPersonagem[1]+2){
                    imagem61.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+1 && j == posicaoDoPersonagem[1]+3){
                    imagem62.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+1 && j == posicaoDoPersonagem[1]+4){
                    imagem63.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+1 && j == posicaoDoPersonagem[1]+5){
                    imagem64.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+1 && j == posicaoDoPersonagem[1]+6){
                    imagem65.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+2 && j == posicaoDoPersonagem[1]-6){
                    imagem66.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+2 && j == posicaoDoPersonagem[1]-5){
                    imagem67.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+2 && j == posicaoDoPersonagem[1]-4){
                    imagem68.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+2 && j == posicaoDoPersonagem[1]-3){
                    imagem69.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+2 && j == posicaoDoPersonagem[1]-2){
                    imagem70.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+2 && j == posicaoDoPersonagem[1]-1){
                    imagem71.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+2 && j == posicaoDoPersonagem[1]){
                    imagem72.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+2 && j == posicaoDoPersonagem[1]+1){
                    imagem73.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+2 && j == posicaoDoPersonagem[1]+2){
                    imagem74.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+2 && j == posicaoDoPersonagem[1]+3){
                    imagem75.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+2 && j == posicaoDoPersonagem[1]+4){
                    imagem76.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+2 && j == posicaoDoPersonagem[1]+5){
                    imagem77.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+2 && j == posicaoDoPersonagem[1]+6){
                    imagem78.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+3 && j == posicaoDoPersonagem[1]-6){
                    imagem79.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+3 && j == posicaoDoPersonagem[1]-5){
                    imagem80.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+3 && j == posicaoDoPersonagem[1]-4){
                    imagem81.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+3 && j == posicaoDoPersonagem[1]-3){
                    imagem82.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+3 && j == posicaoDoPersonagem[1]-2){
                    imagem83.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+3 && j == posicaoDoPersonagem[1]-1){
                    imagem84.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+3 && j == posicaoDoPersonagem[1]){
                    imagem85.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+3 && j == posicaoDoPersonagem[1]+1){
                    imagem86.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+3 && j == posicaoDoPersonagem[1]+2){
                    imagem87.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+3 && j == posicaoDoPersonagem[1]+3){
                    imagem88.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+3 && j == posicaoDoPersonagem[1]+4){
                    imagem89.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+3 && j == posicaoDoPersonagem[1]+5){
                    imagem90.sprite = auxImagem.sprite;
                }else if(i == posicaoDoPersonagem[0]+3 && j == posicaoDoPersonagem[1]+6){
                    imagem91.sprite = auxImagem.sprite;
                }
            }
        }
    }
}
