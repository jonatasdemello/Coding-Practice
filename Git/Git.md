Git Commands

Shortcuts
```
alias ga='git add'
alias gaa='git add .'
alias gaaa='git add --all'
alias gau='git add --update'
alias gb='git branch'
alias gbd='git branch --delete '
alias gc='git commit'
alias gcm='git commit --message'
alias gcf='git commit --fixup'
alias gco='git checkout'
alias gcob='git checkout -b'
alias gcom='git checkout master'
alias gcos='git checkout staging'
alias gcod='git checkout develop'
alias gd='git diff'
alias gda='git diff HEAD'
alias gi='git init'
alias glg='git log --graph --oneline --decorate --all'
alias gld='git log --pretty=format:"%h %ad %s" --date=short --all'
alias gm='git merge --no-ff'
alias gma='git merge --abort'
alias gmc='git merge --continue'
alias gp='git pull'
alias gpr='git pull --rebase'
alias gr='git rebase'
alias gs='git status'
alias gss='git status --short'
alias gst='git stash'
alias gsta='git stash apply'
alias gstd='git stash drop'
alias gstl='git stash list'
alias gstp='git stash pop'
alias gsts='git stash save'
```


Merge
Checkout to the branch which will be changed
```git
git checkout branch_to
```
Run command to merge based in a branch
```git
git merge branch_from
```

Push
```git
git push remote_name branch_name
```


Log
```git
git log
```
Remote
```git
git log remote_name/branch_name
```

Create and checking out
```
git checkout -b <branch_name>
```

Saving without commit
Temporarily saves changes that you don’t want to commit immediately. You can apply the changes later. Example: git stash Saved working directory and index state "WIP on master: 84f241e first commit" HEAD is now at 84f241e first commit (To restore them type "git stash apply")
```git
git stash
```

Search
```git
git grep <statement>
```

Commit
```git
git commit -m "message"
```

Delete
Local
```git
git branch --delete <branch>
git branch -d <branch> # Shorter version
git branch -D <branch> # Force delete un-merged branches
```

Remote
```git
git push origin --delete <branch>  # Git version 1.7.0 or newer
```
Force push
```git
git push --force
```


Back to last commit
Resets your index and working directory to the state of your last commit. Example: git reset --hard HEAD
```git
git reset
```

Back to a specific commit
```
git reset <commit>
```
or delete unstaged
```
git reset --hard <commit>
```

Delete remote
```
git remote rm origin
```

Zip repository
Creates a tar or zip file including the contents of a single tree from your repository. Example: git archive --format=zip master^ README >file.zip
```git
git archive --format=zip master^ README >file.zip
```

Setting up google cloud
After create project and respository in administration area...

Install Git
Install Google Cloud SDK
Run the credential helper script (on Linux or Mac OS X) - Should be in Git Bash
```git
git config credential.helper gcloud.sh
```
or
```git
git config credential.helper gcloud.cmd
```
Add remote repository
```git
git remote add google https://source.developers.google.com/p/[PROJECT_ID]/
```
You're ready to Pull or Push

Repositories
git remote add google https://source.developers.google.com/p/justinian-177222/r/justinian

Tools
Git Lens for VSCode
Git Bash

URLS
Major GIT commands with examples