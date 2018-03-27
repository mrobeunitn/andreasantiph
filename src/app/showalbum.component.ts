
import { Component,OnInit, ViewChild, AfterViewInit } from '@angular/core';
import { RouterModule, Routes,Router,ActivatedRoute, ParamMap } from '@angular/router';
import { ImageService } from './image.service';
import {Image} from './image';
import {Album} from './album';
import * as PhotoSwipe from 'photoswipe';
import * as PhotoSwipeUI_Defautl from 'photoswipe/dist/photoswipe-ui-default.js';
import { debug } from 'util';



@Component({
  selector: 'album-viewer',
  templateUrl: 'htmlfiles/showalbum.component.html',
  styleUrls: ['cssfiles/component.css','cssfiles/image_mask.css'],
  
})

export class ShowAlbumComponent implements OnInit{
  title = 'andrea santi photographer';
  albumimages: Image[] =[];
  albums: Album[] =[];
  constructor(private imageservice :ImageService, private route :ActivatedRoute,  private router: Router ){}

  getAlbumImages() : void{
    this.route.params.subscribe(list => this.imageservice.getImageByAlbum(list['id']).subscribe(image => {
      //here 404 not found error handling
      if(image.length == 0){
         this.router.navigate(['notfound']);
        }
      else{
        this.albumimages = image
      }
    })); 
  }
 
  ngOnInit(): void {
    this.getAlbumImages();
  }


  onImageClicked(id:number):void{
     //prendo gli attributi dall'array che mi serve
     const imagesid = this.albumimages.map(im => im['id']);
     const imagewidth = this.albumimages.map(im => im['width']);
     const imageheight = this.albumimages.map(im => im['height']);
     const elements: any = [];
     //riempio l'array di lightbox
     var pswelem = <HTMLElement> document.querySelectorAll('.pswp')[0];
     for(let i = 0; i < this.albumimages.length; i++){
       var item =
        {
            src: '/api/imagefiles/'+imagesid[i],
            w: imagewidth[i],
            h: imageheight[i]
        }
       elements[i] = item;
   // Initializes and opens PhotoSwip
   }
   var options = {
    index: id // start at first slide
  };
   var gallery = new PhotoSwipe( pswelem,PhotoSwipeUI_Defautl, elements, options);
   gallery.init();
  
  }
}
