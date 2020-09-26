import { Routes, RouterModule } from '@angular/router';
import { ProfileComponent } from './_components/profile/profile.component';
import { CounterComponent } from './_components/counter/counter.component';
import { FetchDataComponent } from './_components/fetch-data/fetch-data.component';
import { HomeComponent } from './_components/home/home.component';
import { AppLayoutComponent } from './_layout';
import { LoadingComponent } from './_components/loading/loading.component';

const appRoutes: Routes = [
    // Site routes goes here
    // {
    //     path: '123456',
    //     component: AppLayoutComponent,
    //     //canActivate: [AuthGuard],
    //     children: [
    //         { path: 'counter', component: CounterComponent },
    //         { path: 'fetch-data', component: FetchDataComponent },
    //         { path: 'home', component: HomeComponent },
    //         { path: 'profile', component: ProfileComponent }
    //     ]
    // },

    // no layout routes
    { path: '', component: LoadingComponent },
    { path: 'home', component: HomeComponent }
];

export const appRouting = RouterModule.forRoot(appRoutes);
