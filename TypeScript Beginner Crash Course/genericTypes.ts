class StorageContainer<T> {
  private contents: T[]

  constructor() {
    this.contents = []
  }

  addItem(item: T): void {
    this.contents.push(item)
  }

  getItem(idx: number): T | undefined {
    return this.contents[idx]
  }
}

const usernames = new StorageContainer<string>()
usernames.addItem("lukasz")
console.log(usernames.getItem(0))
