
import { Component,OnInit, ViewChild, AfterViewInit } from '@angular/core';
import { RouterModule, Routes,Router,ActivatedRoute } from '@angular/router';
import { ImageService } from './image.service';
import {Image} from './image';
import {Album} from './album';
import 'rxjs/add/operator/map'
@Component({
  selector: 'picture-viewer',
  templateUrl: 'htmlfiles/pictureviewer.component.html',
  styleUrls: ['cssfiles/component.css','cssfiles/image_mask.css'],
  
})

export class PictureViewerComponent implements OnInit{
  title = 'andrea santi photographer';
  indeximages: Image[] =[];
  albums: Album[] =[];
  numberOfImages:number;
  numberOfAlbum:number;
  constructor(private imageservice :ImageService, private route :ActivatedRoute,  private router: Router){}


  getIndexImages() : void{
    try{
      this.imageservice.getIndexImage().subscribe(list => {
        //here 404 not found error handling
        console.log("list lenght"+list.length);
        this.indeximages = list
        this.numberOfImages = list.length;
      }); 
    }catch(error){
      this.router.navigate(['notfound']);
    }
    this.imageservice.getAlbum().subscribe(list => {
      this.albums = list
      this.numberOfAlbum = list.length;
    });
    console.log("images lenght"+this.indeximages.length);
    if(this.numberOfAlbum == 0 ||  this.numberOfImages == 0){

    }
  }
 
  ngOnInit(): void {
    this.getIndexImages();
  }

  showAlbum(id):void{
    this.router.navigate(['/album',id]);
  }
  
}
