
import { Component,OnInit, ViewChild, AfterViewInit } from '@angular/core';
import { RouterModule, Routes,Router,ActivatedRoute } from '@angular/router';
import { ImageService } from './image.service';
import {Image} from './image';
import {Album} from './album';
import 'rxjs/add/operator/map'
@Component({
  selector: 'error-viewer',
  templateUrl: 'htmlfiles/error.component.html',
  styleUrls: ['cssfiles/error_page_css/style.css'],
  
})

export class ErrorComponent implements OnInit{
  title = 'andrea santi photographer';
  indeximages: Image[] =[];
  albums: Album[] =[];
  constructor(private imageservice :ImageService, private route :ActivatedRoute,  private router: Router){}


  getIndexImages() : void{
    this.imageservice.getIndexImage().subscribe(list => this.indeximages = list); 
    this.imageservice.getAlbum().subscribe(list => this.albums = list);
  }
 
  ngOnInit(): void {
    this.getIndexImages();
  }

  showAlbum(id):void{
    this.router.navigate(['/album',id]);
  }
  
}
